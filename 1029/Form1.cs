using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace _1029
{
    public partial class terminal : Form
    {
        static Process myprocess = new Process();
        static string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string files_roads;
        static string files_names;

        public terminal()
        { 
            InitializeComponent();
        }

        private void file_writer_Tick(object sender, EventArgs e)
        {
            if(input.Text != "")
            {
                this.Text = input.Text;
            }
            else
            {
                this.Text = "Terminal";
            }
            if (File.Exists(Path.Combine(folderpath, "files_folder_road")))
            {
                files_roads = File.ReadAllText(Path.Combine(folderpath, "files_folder_road")) + "roads.txt";
                files_names = File.ReadAllText(Path.Combine(folderpath, "files_folder_road")) + "names.txt";
            }
            else
            {
                file_writer.Stop();
                MessageBox.Show("Укажите путь к файлам","Сообщение");
                change_road_files CRF = new change_road_files();
                CRF.Show();
            }

            if (input.Text == "doc")
            {
                input.Text = "";
                File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "doc_lang"), "ru");
                doc doc = new doc();
                doc.Show();
            }
            if (input.Text == "delete")
            {
                File.Delete(@"C:\Users\Rodion\Desktop\comand_txt.txt");

                input.Text = "";
            }
            else if (input.Text.Contains("\\"))
            {
                string temp = input.Text;
                if (input.Text.Contains("C:\\") || input.Text.Contains("D:\\"))
                {
                    if (input.Text.Contains("/"))
                    {
                        if (input.Text.Contains("add"))
                        {
                            temp = temp.Replace("add ", "");
                            temp = temp.Replace(" /", "");
                            temp = temp.Replace("add", "");
                            temp = temp.Replace("/", "");

                            File.WriteAllText(@"C:\Users\Rodion\Desktop\comand_txt.txt", temp);
                            string[] file = File.ReadAllLines(@"C:\Users\Rodion\Desktop\comand_txt.txt");
                            string temp_file_names = File.ReadAllText(files_names);
                            string temp_file_roads = File.ReadAllText(files_roads);
                            if (temp_file_names != null)
                            {
                                temp_file_names += "\n" + file[0];
                                temp_file_roads += "\n" + file[1];
                            }
                            else
                            {
                                temp_file_names += file[0];
                                temp_file_roads += file[1];
                            }
                            File.WriteAllText(files_names, temp_file_names);
                            File.WriteAllText(files_roads, temp_file_roads);

                            input.Text = "";
                        } // Add start file
                        else if (!input.Text.Contains("add"))
                        {
                            input.Text = "";
                            try
                            {
                                myprocess.StartInfo.UseShellExecute = true;
                                myprocess.StartInfo.FileName = temp;
                                myprocess.Start();
                            }
                            catch (Exception ex)
                            {
                                input.Text = ex.ToString();
                            }
                        }
                    }
                } // add files
                else
                {
                    if (input.Text.Contains("add") && (input.Text.Contains("https") || input.Text.Contains("http")))
                    {
                        temp = temp.Replace("add ", "");
                        temp = temp.Replace(" \\", "");
                        temp = temp.Replace("add", "");
                        temp = temp.Replace("\\", "");

                        File.WriteAllText(@"C:\Users\Rodion\Desktop\comand_txt.txt", temp);
                        string[] file = File.ReadAllLines(@"C:\Users\Rodion\Desktop\comand_txt.txt");
                        string temp_file_names = File.ReadAllText(@"D:\names.txt");
                        string temp_file_roads = File.ReadAllText(@"D:\roads.txt");
                        if (temp_file_names != null)
                        {
                            temp_file_names += "\n" + file[0];
                            temp_file_roads += "\n" + file[1];
                        }
                        else
                        {
                            temp_file_names += file[0];
                            temp_file_roads += file[1];
                        }
                        File.WriteAllText(files_names, temp_file_names);
                        File.WriteAllText(files_roads, temp_file_roads);

                        input.Text = "";
                    } // add files
                    else if (!input.Text.Contains("add") && (input.Text.Contains("h") || input.Text.Contains("http")))
                    {
                        try
                        {
                            string input_tmp = input.Text;
                            input_tmp = input_tmp.Replace("https://", "");
                            if (input.Text[0] == 'h' && input.Text[1] == ' ')
                            {
                                string input_tmp_2 = input_tmp;
                                input_tmp = "";
                                for (int i = 2; i < input_tmp_2.Length; i++)
                                {
                                    input_tmp += input_tmp_2[i];
                                }
                            }
                            else if (input.Text[0] == 'h' && input.Text[1] != ' ')
                            {
                                string input_tmp_2 = input_tmp;
                                input_tmp = "";
                                for(int i = 1; i < input_tmp_2.Length; i++)
                                {
                                    input_tmp += input_tmp_2[i];
                                }
                            }
                            myprocess.StartInfo.UseShellExecute = true;
                            myprocess.StartInfo.FileName = "https://" + input_tmp;
                            myprocess.Start();
                            input.Text = "";
                        }
                        catch (Exception ex)
                        {
                            input.Text = "'err' - check documentation\nerr:\n" + ex;
                        }
                    } // add links

                    if (input.Text.Contains("name") && input.Text.Contains("id"))
                    {
                        temp = temp.Replace("name ", "");
                        temp = temp.Replace(" \\", "");
                        temp = temp.Replace("name", "");
                        temp = temp.Replace("\\", "");
                        temp = temp.Replace("id ", "");
                        temp = temp.Replace("id", "");

                        File.WriteAllText(@"C:\Users\Rodion\Desktop\comand_txt.txt", temp);
                        string[] file = File.ReadAllLines(@"C:\Users\Rodion\Desktop\comand_txt.txt");
                        string temp_name = File.ReadAllText(@"D:\names_fm.txt");
                        string temp_id = File.ReadAllText(@"D:\ides.txt");
                        if (temp_name != null)
                        {
                            temp_name += "\n" + file[0];
                            temp_id += "\n" + file[1];
                        }
                        else
                        {
                            temp_name += file[0];
                            temp_id += file[1];
                        }
                        File.WriteAllText(@"D:\names_fm.txt", temp_name);
                        File.WriteAllText(@"D:\ides.txt", temp_id);

                        input.Text = "";
                    } // add names for message

                    if(input.Text[0] == 'M' || input.Text[0] == 'm')
                    {
                        try
                        {
                            temp = temp.Replace("M ", "");
                            temp = temp.Replace(" \\", "");
                            temp = temp.Replace("M", "");
                            temp = temp.Replace("\\", "");
                            temp = temp.Replace("m ", "");
                            temp = temp.Replace("m", "");

                            File.WriteAllText(@"C:\Users\Rodion\Desktop\comand_txt.txt", temp);
                            string[] file = File.ReadAllLines(@"C:\Users\Rodion\Desktop\comand_txt.txt");
                            string temp_name = File.ReadAllText(@"D:\names_fm.txt");
                            string temp_id = File.ReadAllText(@"D:\ides.txt");
                            string[] temp_id_arr = File.ReadAllLines(@"D:\ides.txt");
                            string[] temp_name_arr = File.ReadAllLines(@"D:\names_fm.txt");

                            if (temp_name != null)
                            {
                                for (int i = 1; i < File.ReadAllLines(@"D:\names_fm.txt").Length; i++)
                                {
                                    if (input.Text.Contains(temp_name_arr[i]))
                                    {
                                        input.Text = "";
                                        try
                                        {
                                            File.WriteAllText(@"C:\Users\Rodion\Desktop\bot\text.txt", file[0]);
                                            File.WriteAllText(@"C:\Users\Rodion\Desktop\bot\id.txt", temp_id_arr[i].ToString());

                                            ProcessStartInfo startInfo = new ProcessStartInfo("python");
                                            Process process = new Process();
                                            startInfo.WorkingDirectory = @"C:\Users\Rodion\Desktop\bot";
                                            startInfo.Arguments = "main.py";
                                            startInfo.UseShellExecute = false;
                                            startInfo.CreateNoWindow = true;
                                            process.StartInfo = startInfo;
                                            process.Start();
                                        }
                                        catch (Exception ex)
                                        {
                                            input.Text = ex.ToString();
                                        }
                                        break;
                                    }
                                }
                            }

                            input.Text = "";
                        }
                        catch(Exception ex)
                        {
                            input.Text = ex.ToString();
                        }
                    }// send message in telegram

                    try
                    {
                        if ((input.Text[0] == 'k' && input.Text[1] == 'p') || ((input.Text[0] == 'K' && input.Text[1] == 'P')))
                        {
                            temp = temp.Replace("KP ", "");
                            temp = temp.Replace("kp ", "");
                            temp = temp.Replace(" \\", "");
                            temp = temp.Replace("\\", "");
                            myprocess.StartInfo.UseShellExecute = true;
                            myprocess.StartInfo.FileName = "https://www.kinopoisk.ru/index.php?kp_query=" + temp;
                            myprocess.Start();
                            input.Text = "goto: " + "https://www.kinopoisk.ru/index.php?kp_query=" + temp;
                        } // search films in konopoisk
                        else if (input.Text[0] == 'Y' || input.Text[0] == 'y')
                        {
                            if (input.Text.Contains("https"))
                            {
                                input.Text = "";
                                temp = temp.Replace("Y ", "");
                                temp = temp.Replace("y ", "");
                                temp = temp.Replace(" \\", "");
                                temp = temp.Replace("\\", "");
                                myprocess.StartInfo.UseShellExecute = true;
                                myprocess.StartInfo.FileName = temp;
                                myprocess.Start();
                            }
                            else
                            {
                                temp = temp.Replace("Y ", "");
                                temp = temp.Replace("y ", "");
                                temp = temp.Replace(" \\", "");
                                temp = temp.Replace("\\", "");
                                myprocess.StartInfo.UseShellExecute = true;
                                myprocess.StartInfo.FileName = "https://www.youtube.com/results?search_query=" + temp;
                                myprocess.Start();
                                input.Text = "goto: " + "https://www.youtube.com/results?search_query=" + temp;
                            }
                        } // search in youtube
                        else if (input.Text[0] == 'S' || input.Text[0] == 's')
                        {
                            temp = temp.Replace("S ", "");
                            temp = temp.Replace("s ", "");
                            temp = temp.Replace(" \\", "");
                            temp = temp.Replace("\\", "");
                            myprocess.StartInfo.UseShellExecute = true;
                            myprocess.StartInfo.FileName = "https://www.google.ru/search?q=" + temp;
                            myprocess.Start();
                            input.Text = "goto: " + "https://www.google.ru/search?q=" + temp;
                        } // search in google
                        else if (input.Text[0] == 'a' && input.Text[1] == 'l' && input.Text[2] == 'i')
                        {
                            input.Text = "";
                            temp = temp.Replace("ali ", "");
                            temp = temp.Replace(" \\", "");
                            temp = temp.Replace("\\", "");
                            myprocess.StartInfo.UseShellExecute = true;
                            myprocess.StartInfo.FileName = @"https://aliexpress.ru/wholesale?catId=0&initiative_id=SB_20220227014341&SearchText=" + temp;
                            myprocess.Start();
                        } // search in AliExpress off PC
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("'err' - check documentation\nerr:\n" + ex);
                    }
                } // add internet links and use internet links
                if (input.Text == "power off\\" || input.Text == "power off \\" || input.Text == "зщцук щаа\\")
                {
                    input.Text = "";
                    Process.Start("shutdown", "/s /t 0");
                } // power off
                if (input.Text == "cmd\\" || input.Text == "cmd \\" || input.Text == "сьв\\")
                {
                    input.Text = "";
                    Process.Start("cmd");
                } // open cmd    

            } // Enter
            else if (input.Text == "clear")
            {
                File.WriteAllText(files_names, "");
                File.WriteAllText(files_roads, "");

                input.Text = "";
            } // clear names and roads files
            else if (input.Text == "mod_code" || input.Text == "mod code" || input.Text == "ьщв сщву" || input.Text == "ьщв_сщву")
            {
                input.Text = "";
                try
                {
                    myprocess.StartInfo.UseShellExecute = true;
                    myprocess.StartInfo.FileName = @"C:\Users\Rodion\source\repos\1029\1029.sln";
                    myprocess.Start();
                }
                catch (Exception ex)
                {
                    input.Text = ex.ToString();
                }
            } // open code of Terminal
            else
            {
                int file_count = File.ReadAllLines(files_names).Length;
                for (int i = 1; i < file_count; i++)
                {
                    if (input.Text == File.ReadAllLines(files_names)[i])
                    {
                        input.Text = "";
                        try
                        {
                            myprocess.StartInfo.UseShellExecute = true;
                            myprocess.StartInfo.FileName = File.ReadAllLines(files_roads)[i];
                            myprocess.Start();
                        }
                        catch (Exception ex)
                        {
                            input.Text = ex.ToString();
                        }
                    }
                }
            } // open any file
            try
            {
                if (input.Text.Contains("cls") || input.Text[0] == 'c' && input.Text[1] == 'l' && input.Text[2] == 's')
                {
                    input.Text = "";
                } // clear console
            }
            catch (Exception ex)
            {
                Console.WriteLine("'err' - check documentation\nerr:\n" + ex);
            } // clear terminal
        }
    }
}