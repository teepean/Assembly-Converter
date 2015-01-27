using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Assembly_Converter
{
    class AssemblyUtil
    {
        public static byte[] Zip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public static byte[] Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return mso.ToArray();
            }
        }

        public static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        public static void convertAssembly(string input_file, string chain_file, string output_file)
        {
            Dictionary<long, long>[] chain_map = readChain(chain_file);
            string line = null;
            string[] data = null;
            List<string> lines = new List<string>();
            if (input_file.EndsWith(".gz"))
            {
                StringReader reader = new StringReader(Encoding.UTF8.GetString(Unzip(File.ReadAllBytes(input_file))));
                while((line = reader.ReadLine())!=null)
                {
                    lines.Add(line);
                }
                reader.Close();

            }
            else if (input_file.EndsWith(".zip"))
            {
                using (var fs = new MemoryStream(File.ReadAllBytes(input_file)))
                using (var zf = new ZipFile(fs))
                {
                    var ze = zf[0];
                    if (ze == null)
                    {
                        throw new ArgumentException("file not found in Zip");
                    }
                    using (var s = zf.GetInputStream(ze))
                    {
                        using (StreamReader sr = new StreamReader(s))
                        {
                            while ((line = sr.ReadLine()) != null)
                            {
                                lines.Add(line);
                            }
                        }
                    }
                }
            }
            else
                lines = File.ReadAllLines(input_file).ToList();

            ////////
            char[] spliter = new char[] { ',', '\t' };

            StringBuilder sb = new StringBuilder();      
            long new_pos=0;
            string new_line = null;
            foreach(string l in lines)
            {
                if (l.StartsWith("RSID") || l.StartsWith("rsid") || l.StartsWith("#") || l.Trim() == "")
                {
                    sb.Append(l);
                    sb.Append("\r\n");
                    continue;
                }
                //
                data=l.Replace("\"","").Split(spliter);
                new_pos = getNewPosition(data[1], long.Parse(data[2]), chain_map);
                if (new_pos == -1)
                    continue;
                new_line = l.Replace("\t" + data[2] + "\t", "\t" + new_pos.ToString() + "\t");
                new_line = new_line.Replace("\"" + data[2] + "\"", "\"" + new_pos.ToString() + "\"");
                sb.Append(new_line);
                sb.Append("\r\n");
            }

            File.WriteAllText(output_file, sb.ToString());
        }

        private static Dictionary<long,long>[] readChain(string chain_file)
        {
            Dictionary<long, long>[] pos_map = new Dictionary<long, long>[25];
            for (int i = 0; i < 25; i++)
                pos_map[i] = new Dictionary<long, long>();
            string line = null;
            string[] data = null;
            char[] tab = new char[] { '\t',' ' };
            StringReader reader = new StringReader(Encoding.UTF8.GetString(Unzip(File.ReadAllBytes(chain_file))));
            long old_pos_idx = 0;
            long new_pos_idx = 0;
            int chr = 0;
            string tmp = null;
            string[] d2 = null;
            while ((line = reader.ReadLine()) != null)
            {
                if(line.StartsWith("chain"))
                {
                    data = line.Split(tab);

                    if (data[2] == data[7] && data[4] == data[9] && Regex.Replace(data[2].Replace("chr", ""), "[0-9XYM]", "") == "")
                    {
                        tmp = data[2].Replace("chr", "");
                        try
                        {
                            if (tmp == "X")
                                chr = 22;
                            else if (tmp == "Y")
                                chr = 23;
                            else if (tmp == "M")
                                chr = 24;
                            else
                                chr = int.Parse(tmp)-1;
                        }
                        catch (Exception)
                        {
                            continue;
                        }                        

                        old_pos_idx = long.Parse(data[5]);
                        new_pos_idx = long.Parse(data[10]);

                        pos_map[chr].Add(old_pos_idx, new_pos_idx);

                        while ((line = reader.ReadLine()) != "")
                        {
                            d2 = line.Split(tab);
                            if (d2.Length == 3)
                            {
                                old_pos_idx = old_pos_idx + long.Parse(d2[0]) + long.Parse(d2[1]);
                                new_pos_idx = new_pos_idx + long.Parse(d2[0]) + long.Parse(d2[2]);
                                pos_map[chr].Add(old_pos_idx, new_pos_idx);
                            }
                            /*
                             * -- not required --
                            else
                            {
                                old_pos_idx = old_pos_idx + long.Parse(d2[0]);
                                new_pos_idx = new_pos_idx + long.Parse(d2[0]);
                                pos_map[chr].Add(old_pos_idx, new_pos_idx);
                            }
                            */
                        }
                    }
                }
            }
            reader.Close();
            return pos_map;
        }

        private static long getNewPosition(string chr_str, long old_pos, Dictionary<long, long>[] chain_map)
        {
            int chr = -1;
            try
            {
                if (chr_str == "X")
                    chr = 22;
                else if (chr_str == "Y")
                    chr = 23;
                else if (chr_str == "M")
                    chr = 24;
                else
                    chr = int.Parse(chr_str)-1;
            }
            catch (Exception)
            {
                return -1;
            }

            if (chr == -1)
                return -1;

            List<long> pos_list = chain_map[chr].Keys.ToList();
            pos_list.Sort();
            long new_pos_idx = 0;
            foreach (long pos in pos_list)
            {
                if (pos > old_pos)                
                    break;                
                else
                    new_pos_idx = chain_map[chr][pos] + (old_pos - pos);                    
            }

            return new_pos_idx;
        }
    }
}
