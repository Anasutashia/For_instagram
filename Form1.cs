using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        void Visible_Changes(int numberofbutton)
        {
            switch (numberofbutton) 
            {
                case 0:
                    button9.Visible = false; //1- подписчики 
                    button10.Visible = false;//1- подписчики 
                    button11.Visible = false;//1- подписчики 
                //  label1.Visible = false;  //укажите путь
                    label2.Visible = false; //путь
                    button6.Visible = false; //2- подписки
                    button7.Visible = false; //2- подписки
                    button8.Visible = false; //2- подписки
                    textBox1.Visible = false; //проверка подписки\подписчики
                    textBox2.Visible = false; //вывод нет подписки\не подписавшихся
                    button12.Visible = false;//сохранение  не подписавшихся!
                    button13.Visible = false;//сохранение нет подписки
                    button1.Visible = false; //кнопки слева
                    button2.Visible = false; //кнопки слева
                    button3.Visible = false; //кнопки слева
                    button4.Visible = false; //кнопки слева
                    button5.Visible = false;//кнопки слева
                    button14.Visible = false;// выбор профилей проф 1
                    button15.Visible = false;// выбор профилей проф 2
                    button16.Visible = false;// выбор профилей проф 3
                    button17.Visible = false;// сменить профиль спарва сверху
                    button18.Visible = false;//отсутсвует бд - создать
                    button19.Visible = false;//отсутсвует бд - указать
                    button20.Visible = false;//кнопка создать, проф 1 кнопка 14
                    button21.Visible = false;//кнопка создать, проф 2 кнопка 15
                    button22.Visible = false;//кнопка создать, проф 3 кнопка 16
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;//тест
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;
                    break;
                case 1:
                    button1.ForeColor = Color.White; //ПОДПИСЧИКИ
                    button2.ForeColor = Color.FromArgb(153, 153, 153);
                    button3.ForeColor = Color.FromArgb(153, 153, 153);
                    button4.ForeColor = Color.FromArgb(153, 153, 153);
                    button5.ForeColor = Color.FromArgb(153, 153, 153);
                    button9.Visible = true;  //1- подписчики 
                    button10.Visible = true; //1- подписчики 
                    button11.Visible = true; //1- подписчики 
                    label1.Visible = true;
                    label2.Visible = true;
                    button6.Visible = false;//2- подписки
                    button8.Visible = false;//2- подписки
                    button7.Visible = false;//2- подписки
                    textBox1.Clear();
                    //textfile = null;
                    textBox1.Visible = true;
                    textBox2.Visible = false; //вывод нет подписки\не подписавшихся
                    button12.Visible = false;//сохранение  не подписавшихся!
                    button13.Visible = false;//сохранение нет подписки
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    checkBox2.Visible = false;
                    checkBox1.Visible = true;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;
                    break;
                case 2:
                    button2.ForeColor = Color.White; //ПОДПИСКИ
                    button1.ForeColor = Color.FromArgb(153, 153, 153);
                    button3.ForeColor = Color.FromArgb(153, 153, 153);
                    button4.ForeColor = Color.FromArgb(153, 153, 153);
                    button5.ForeColor = Color.FromArgb(153, 153, 153);
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    label1.Visible = true;
                    label2.Visible = true;
                    button6.Visible = true; //2- подписки
                    button8.Visible = true; //2- подписки
                    button7.Visible = true; //2- подписки
                    textBox1.Clear();
                    //textfile = null;
                    textBox1.Visible = true;
                    textBox2.Visible = false; //вывод нет подписки\не подписавшихся
                    button12.Visible = false;//сохранение  не подписавшихся!
                    button13.Visible = false;//сохранение нет подписки
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    checkBox1.Visible = false;
                    checkBox2.Visible = true;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;
                    break;
                case 3:
                    button3.ForeColor = Color.White; //Не подписаны на аккаунт
                    button1.ForeColor = Color.FromArgb(153, 153, 153);
                    button2.ForeColor = Color.FromArgb(153, 153, 153);
                    button4.ForeColor = Color.FromArgb(153, 153, 153);
                    button5.ForeColor = Color.FromArgb(153, 153, 153);
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    label1.Visible = true;
                    label2.Visible = false;
                    button6.Visible = false;//2- подписки
                    button8.Visible = false;//2- подписки
                    button7.Visible = false;//2- подписки
                    textBox1.Visible = false;
                    textBox2.Clear();
                    textBox2.Visible = true; //вывод нет подписки\не подписавшихся
                    button12.Visible = true;//сохранение  не подписавшихся!
                    button13.Visible = false;//сохранение нет подписки
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = true;
                    checkBox4.Visible = true;
                    break;
                case 4:
                    button4.ForeColor = Color.White; //Нет подписки на аккаунты
                    button1.ForeColor = Color.FromArgb(153, 153, 153);
                    button2.ForeColor = Color.FromArgb(153, 153, 153);
                    button3.ForeColor = Color.FromArgb(153, 153, 153);
                    button5.ForeColor = Color.FromArgb(153, 153, 153);
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    label1.Visible = true;
                    label2.Visible = false;
                    button6.Visible = false;//2- подписки
                    button8.Visible = false;//2- подписки
                    button7.Visible = false;//2- подписки
                    textBox1.Visible = false;
                    textBox2.Clear();
                    textBox2.Visible = true; //вывод нет подписки\не подписавшихся
                    button12.Visible = false;//сохранение  не подписавшихся!
                    button13.Visible = true;//сохранение нет подписки
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;
                    break;
                case 5:
                    button5.ForeColor = Color.White; //статистика
                    button1.ForeColor = Color.FromArgb(153, 153, 153);
                    button2.ForeColor = Color.FromArgb(153, 153, 153);
                    button3.ForeColor = Color.FromArgb(153, 153, 153);
                    button4.ForeColor = Color.FromArgb(153, 153, 153);
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    button6.Visible = false;//2- подписки
                    button8.Visible = false;//2- подписки
                    button7.Visible = false;//2- подписки
                    textBox1.Visible = false;
                    textBox2.Visible = false; //вывод нет подписки\не подписавшихся
                    button12.Visible = false;//сохранение  не подписавшихся!
                    button13.Visible = false;//сохранение нет подписки
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
            Visible_Changes(0);

            label1.Text = "Выбор профиля";

            //string pathFile = Application.StartupPath + "db.txt";
            if (System.IO.File.Exists("db.txt"))
            {
                button14.Visible = true;// выбор профилей проф 1
                button15.Visible = true;// выбор профилей проф 2
                button16.Visible = true;// выбор профилей проф 3
                button17.Visible = true;
            }
            else
            {
                button19.Visible = true;//отсутсвует бд - указать
                button18.Visible = true;//отсутсвует бд - создать
            }


        }
            public static string filename1;
            public static string filename2;
            public static string filepathtoold ;
           //public static string textfile;
           //public static string needed_textfile;
            public static int podpischiki=0;
            public static int podpiski=0;
            public static int ne_podpisni=0;
            public static int net_podpiski=0;
            public static int razn;
            public static int razn2;
            public static int flag=0;
            public static int flag1 = 0; 
            public static int flag2 = 0;
            public static int flag3 = 0;
            public static List<string> fileList3;
            public static List<string> fileList4;



        private void button1_Click(object sender, EventArgs e) //кнопка "подписчики"
        {

            Visible_Changes(1);
            label1.Text = "Выберите путь к файлу";

        }

        private void button2_Click(object sender, EventArgs e) //кнопка "подписки"
        {

            Visible_Changes(2);
            label1.Text = "Выберите путь к файлу";

        }

        private void button3_Click(object sender, EventArgs e) //кнопка "не подписаны"
        {
            Visible_Changes(3);
            label1.Text = "Не подписаны на аккаунт";

                if ((filename1 != null) && (filename2 != null))
                {
                    //string a3 = "D:\\test\\03.txt";
                    var fileList = File.ReadAllLines(filename1).ToList(); //подписчики
                    var fileList2 = File.ReadAllLines(filename2).ToList(); //подписки
                    //var fileList3 = File.ReadAllLines(a3).ToList();
                    //List<string> fileList3 = new List<string>();
                    //List<string> fileList4 = new List<string>();
                    for (var i = fileList.Count - 1; i >= 0; i--)
                    {

                        if (!fileList[i].Contains("Фото профиля"))
                        {
                            fileList.RemoveAt(i); //Удаление строки целиком
                        };

                    };

                    for (var i = fileList2.Count - 1; i >= 0; i--)
                    {

                        if (!fileList2[i].Contains("Фото профиля"))
                        {
                            fileList2.RemoveAt(i); //Удаление строки целиком
                        };
                    };

                    podpischiki = fileList.Count;
                    podpiski = fileList2.Count;
                    //fileList.Sort();
                    //fileList2.Sort();
                    fileList3 = fileList2;
                    fileList3=(fileList3.Except(fileList)).ToList();
                    fileList3.Sort();
                    /** fileList3.AddRange(fileList);
                    fileList.AddRange(fileList2);
                    fileList.Sort();
                    for (var i = fileList.Count - 1; i >= 0; i--)
                    {

                        if (i >= 1)
                            if (fileList[i].ToString() == fileList[i - 1].ToString())
                            {
                                fileList4.Add(fileList[i]);
                                fileList.RemoveAt(i);
                                fileList.RemoveAt(i - 1);//Удаление строки целиком
                                i--;
                            };
                    };

                    fileList.AddRange(fileList3);
                    fileList.AddRange(fileList4);
                    fileList.Sort();

                    for (var i = fileList.Count - 1; i >= 0; i--)
                    {

                        if (i >= 1)
                            if (fileList[i].ToString() == fileList[i - 1].ToString())
                            {
                                fileList.RemoveAt(i);
                                fileList.RemoveAt(i - 1);//Удаление строки целиком
                                i--;
                            };
                    }; */
                    ne_podpisni = fileList3.Count;
                    for (int i = 0; i < fileList3.Count; i++)
                    {
                        textBox2.Text += (fileList3[i].ToString().Replace("Фото профиля", "")) + Environment.NewLine;
                    }
                }
                else
                    textBox2.Text = "Выберите файлы с подписчиками и подписками";
            
        }

        private void button4_Click(object sender, EventArgs e) //кнопка "нет подписки(я не подписана)"
        {
            Visible_Changes(4);

            label1.Text = "Нет подписок на аккаунты";
            if ((filename1 != null) && (filename2 != null))
            {
               // string a3 = "D:\\test\\03.txt";
                var fileList = File.ReadAllLines(filename1).ToList();
                var fileList2 = File.ReadAllLines(filename2).ToList();
                //var fileList3 = File.ReadAllLines(a3).ToList();
                //var fileList4 = File.ReadAllLines(a3).ToList();
                //List<string> fileList3 = new List<string>();
                //List<string> fileList4 = new List<string>();
                for (var i = fileList.Count - 1; i >= 0; i--)
                {

                    if (!fileList[i].Contains("Фото профиля"))
                    {
                        fileList.RemoveAt(i); //Удаление строки целиком
                    };

                };

                for (var i = fileList2.Count - 1; i >= 0; i--)
                {

                    if (!fileList2[i].Contains("Фото профиля"))
                    {
                        fileList2.RemoveAt(i); //Удаление строки целиком
                    };
                }
                
                podpischiki = fileList.Count;
                podpiski = fileList2.Count;
                fileList.Sort();
                fileList2.Sort();
                fileList4 = fileList;
                fileList4 = (fileList4.Except(fileList2)).ToList();                
                /**
                fileList3.AddRange(fileList2);
                fileList.AddRange(fileList2);
                fileList.Sort();
                for (var i = fileList.Count - 1; i >= 0; i--)
                {

                    if (i >= 1)
                        if (fileList[i].ToString() == fileList[i - 1].ToString())
                        {
                            fileList4.Add(fileList[i]);
                            fileList.RemoveAt(i);
                            fileList.RemoveAt(i - 1);//Удаление строки целиком
                            i--;
                        };
                };

                fileList.AddRange(fileList3);
                fileList.AddRange(fileList4);
                fileList.Sort();

                for (var i = fileList.Count - 1; i >= 0; i--)
                {

                    if (i >= 1)
                        if (fileList[i].ToString() == fileList[i - 1].ToString())
                        {
                            fileList.RemoveAt(i);
                            fileList.RemoveAt(i - 1);//Удаление строки целиком
                            i--;
                        };
                }; **/
                net_podpiski = fileList4.Count;
                
                for (int i = 0; i < fileList4.Count; i++)
                {
                    textBox2.Text +=(fileList4[i].ToString().Replace("Фото профиля", "")) + Environment.NewLine;
                }
            }
            else
                textBox2.Text = "Выберите файлы с подписчиками и подписками";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Visible_Changes(5);
            //if (label4.Text == "4 Всего подписчиков :")
            if (podpischiki != 0)
            {
                label4.Text = "4 Всего подписчиков :";
                
                label4.Text += podpischiki;
              
            }
            if (podpiski != 0)
            {
                label3.Text = "3 Всего подписок :";
                label3.Text += podpiski;
                
            }
            if (ne_podpisni != 0)
            {
                label8.Text = "8 Не подписаны на акккаунт :";
                label8.Text += ne_podpisni;
              
            }
            if (net_podpiski != 0)
            {
                label7.Text = "7 нет подписки на аккаунты :";
                label7.Text += net_podpiski;
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //OpenFileDialog opfd = new OpenFileDialog();
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;

            filename2 = openFileDialog2.FileName;
            // читаем файл в строку
            //textfile = System.IO.File.ReadAllText(filename2);
            //string fileText = System.IO.File.ReadAllText(filename);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(filename2); //
            //textBox1.Text = fileText;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                filename2 = File.ReadAllText("p2.txt");
                //textfile = File.ReadAllText(filename1);
            }
            else
            {
                File.WriteAllText("p2.txt", filename2);
                //textfile = File.ReadAllText(filename1);
            }
        }

        private void button9_Click(object sender, EventArgs e)//подтвердить
        {
            if (checkBox1.Checked == true)
            {
                filename1 = File.ReadAllText("p1.txt"); 
                //textfile = File.ReadAllText(filename1);
            }
            else
            {
                File.WriteAllText("p1.txt", filename1);
                //textfile = File.ReadAllText(filename1);
            }
            // читаем файл в строку
           // textfile = System.IO.File.ReadAllText(filename1);
           // textBox1.Text = filename1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(filename1);
            //  textBox1.Text = fileText;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                //OpenFileDialog opfd = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                filename1 = openFileDialog1.FileName;
                // читаем файл в строку
                //textfile = System.IO.File.ReadAllText(filename1);
                // string fileText = System.IO.File.SelectedPath;
                textBox1.Text = filename1;
                // string path = "p1.txt";
                //string createText = textBox1.Text;
                //  File.WriteAllText(path, createText);
                //filepathtoold = path;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox2.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox2.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string pathFile = Application.StartupPath + "p1.txt";
            if (System.IO.File.Exists("p1.txt"))
            {
                button9.Visible = false; //1- подписчики 
                button10.Visible = false;//1- подписчики 
                button11.Visible = false;//1- подписчики 
                label1.Visible = false;  //укажите путь
                label2.Visible = false; //путь
                button6.Visible = false; //2- подписки
                button7.Visible = false; //2- подписки
                button8.Visible = false; //2- подписки
                textBox1.Visible = false; //проверка подписки\подписчики
                textBox2.Visible = false; //вывод нет подписки\не подписавшихся
                button12.Visible = false;//сохранение  не подписавшихся!
                button13.Visible = false;//сохранение нет подписки
                button1.Visible = true; //кнопки слева
                button2.Visible = true; //кнопки слева
                button3.Visible = true; //кнопки слева
                button4.Visible = true; //кнопки слева
                button5.Visible = true; //кнопки слева
                button14.Visible = false; //кнопки профиль
                button15.Visible = false; //кнопки профиль
                button16.Visible = false; //кнопки профиль
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;

                button17.Text = "Профиль1";
            }
            else
            {
                button20.Visible = true;
                button14.Visible = false;// выбор профилей проф 1
                button15.Visible = false;// выбор профилей проф 2
                button16.Visible = false;// выбор профилей проф 3
                button17.Visible = false;// сменить профиль спарва сверху



            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string pathFile = Application.StartupPath + "p2.txt";
            if (System.IO.File.Exists("p2.txt"))
            {
                button9.Visible = false; //1- подписчики 
            button10.Visible = false;//1- подписчики 
            button11.Visible = false;//1- подписчики 
            label1.Visible = false;  //укажите путь
            label2.Visible = false; //путь
            button6.Visible = false; //2- подписки
            button7.Visible = false; //2- подписки
            button8.Visible = false; //2- подписки
            textBox1.Visible = false; //проверка подписки\подписчики
            textBox2.Visible = false; //вывод нет подписки\не подписавшихся
            button12.Visible = false;//сохранение  не подписавшихся!
            button13.Visible = false;//сохранение нет подписки
            button1.Visible = true; //кнопки слева
            button2.Visible = true; //кнопки слева
            button3.Visible = true; //кнопки слева
            button4.Visible = true; //кнопки слева
            button5.Visible = true; //кнопки слева
            button14.Visible = false; //кнопки профиль
            button15.Visible = false; //кнопки профиль
            button16.Visible = false; //кнопки профиль
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;

            button17.Text = "Профиль2";
            }
            else
            {
                button21.Visible = true;
                button14.Visible = false;// выбор профилей проф 1
                button15.Visible = false;// выбор профилей проф 2
                button16.Visible = false;// выбор профилей проф 3
                button17.Visible = false;// сменить профиль спарва сверху



            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string pathFile = Application.StartupPath + "p3.txt";
            if (System.IO.File.Exists("p3.txt"))
            {
                button9.Visible = false; //1- подписчики 
            button10.Visible = false;//1- подписчики 
            button11.Visible = false;//1- подписчики 
            label1.Visible = false;  //укажите путь
            label2.Visible = false; //путь
            button6.Visible = false; //2- подписки
            button7.Visible = false; //2- подписки
            button8.Visible = false; //2- подписки
            textBox1.Visible = false; //проверка подписки\подписчики
            textBox2.Visible = false; //вывод нет подписки\не подписавшихся
            button12.Visible = false;//сохранение  не подписавшихся!
            button13.Visible = false;//сохранение нет подписки
            button1.Visible = true; //кнопки слева
            button2.Visible = true; //кнопки слева
            button3.Visible = true; //кнопки слева
            button4.Visible = true; //кнопки слева
            button5.Visible = true; //кнопки слева
            button14.Visible = false; //кнопки профиль
            button15.Visible = false; //кнопки профиль
            button16.Visible = false; //кнопки профиль
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;

            button17.Text = "Профиль3";
            }
            else
            {
                button22.Visible = true;
                button14.Visible = false;// выбор профилей проф 1
                button15.Visible = false;// выбор профилей проф 2
                button16.Visible = false;// выбор профилей проф 3
                button17.Visible = false;// сменить профиль спарва сверху



            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button9.Visible = false; //1- подписчики 
            button10.Visible = false;//1- подписчики 
            button11.Visible = false;//1- подписчики 
                                     //  label1.Visible = false;  //укажите путь
            label2.Visible = false; //путь
            button6.Visible = false; //2- подписки
            button7.Visible = false; //2- подписки
            button8.Visible = false; //2- подписки 
            textBox1.Visible = false; //проверка подписки\подписчики
            textBox2.Visible = false; //вывод нет подписки\не подписавшихся
            button12.Visible = false;//сохранение  не подписавшихся!
            button13.Visible = false;//сохранение нет подписки
            button1.Visible = false; //кнопки слева
            button2.Visible = false; //кнопки слева
            button3.Visible = false; //кнопки слева
            button4.Visible = false; //кнопки слева
            button5.Visible = false; //кнопки слева
            button14.Visible = true; //кнопки профиль
            button15.Visible = true; //кнопки профиль
            button16.Visible = true; //кнопки профиль
            label3.Visible = false; //
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;

            label1.Text = "Выбор профиля";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.IO.File.Create("db.txt");
            button14.Visible = true;// выбор профилей проф 1
            button15.Visible = true;// выбор профилей проф 2
            button16.Visible = true;// выбор профилей проф 3
            button17.Visible = true;
            button18.Visible = false;
            button19.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.Cancel)
                return;
            button14.Visible = true;// выбор профилей проф 1
            button15.Visible = true;// выбор профилей проф 2
            button16.Visible = true;// выбор профилей проф 3
            button17.Visible = true;
            button18.Visible = false;
            button19.Visible = false;


        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.IO.File.Create("p1.txt");
            button9.Visible = false; //1- подписчики 
            button10.Visible = false;//1- подписчики 
            button11.Visible = false;//1- подписчики 
            label1.Visible = false;  //укажите путь
            label2.Visible = false; //путь
            button6.Visible = false; //2- подписки
            button7.Visible = false; //2- подписки
            button8.Visible = false; //2- подписки
            textBox1.Visible = false; //проверка подписки\подписчики
            textBox2.Visible = false; //вывод нет подписки\не подписавшихся
            button12.Visible = false;//сохранение  не подписавшихся!
            button13.Visible = false;//сохранение нет подписки
            button1.Visible = true; //кнопки слева
            button2.Visible = true; //кнопки слева
            button3.Visible = true; //кнопки слева
            button4.Visible = true; //кнопки слева
            button5.Visible = true; //кнопки слева
            button14.Visible = false; //кнопки профиль
            button15.Visible = false; //кнопки профиль
            button16.Visible = false; //кнопки профиль
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            button20.Visible = false;
            button17.Visible = true;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            System.IO.File.Create("p2.txt");
            button9.Visible = false; //1- подписчики 
            button10.Visible = false;//1- подписчики 
            button11.Visible = false;//1- подписчики 
            label1.Visible = false;  //укажите путь
            label2.Visible = false; //путь
            button6.Visible = false; //2- подписки
            button7.Visible = false; //2- подписки
            button8.Visible = false; //2- подписки
            textBox1.Visible = false; //проверка подписки\подписчики
            textBox2.Visible = false; //вывод нет подписки\не подписавшихся
            button12.Visible = false;//сохранение  не подписавшихся!
            button13.Visible = false;//сохранение нет подписки
            button1.Visible = true; //кнопки слева
            button2.Visible = true; //кнопки слева
            button3.Visible = true; //кнопки слева
            button4.Visible = true; //кнопки слева
            button5.Visible = true; //кнопки слева
            button14.Visible = false; //кнопки профиль
            button15.Visible = false; //кнопки профиль
            button16.Visible = false; //кнопки профиль
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            button21.Visible = false;
            button17.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            System.IO.File.Create("p3.txt");
            button9.Visible = false; //1- подписчики 
            button10.Visible = false;//1- подписчики 
            button11.Visible = false;//1- подписчики 
            label1.Visible = false;  //укажите путь
            label2.Visible = false; //путь
            button6.Visible = false; //2- подписки
            button7.Visible = false; //2- подписки
            button8.Visible = false; //2- подписки
            textBox1.Visible = false; //проверка подписки\подписчики
            textBox2.Visible = false; //вывод нет подписки\не подписавшихся
            button12.Visible = false;//сохранение  не подписавшихся!
            button13.Visible = false;//сохранение нет подписки
            button1.Visible = true; //кнопки слева
            button2.Visible = true; //кнопки слева
            button3.Visible = true; //кнопки слева
            button4.Visible = true; //кнопки слева
            button5.Visible = true; //кнопки слева
            button14.Visible = false; //кнопки профиль
            button15.Visible = false; //кнопки профиль
            button16.Visible = false; //кнопки профиль
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            button22.Visible = false;
            button17.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            if (checkBox3.Checked == true)
                for (int i = 0; i < fileList3.Count; i++)
                {
                    textBox2.Text += i + (fileList3[i].ToString().Replace("Фото профиля", "")) + Environment.NewLine;
                }
            else
                for (int i = 0; i < fileList3.Count; i++)
                {
                    textBox2.Text += (fileList3[i].ToString().Replace("Фото профиля", "")) + Environment.NewLine;
                }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            if (checkBox4.Checked == true)
                for (int i = 0; i < fileList3.Count; i++)
                {
                    if ((i % 10 == 0) && (i!=0))
                        textBox2.Text += Environment.NewLine;
                    textBox2.Text += i + (fileList3[i].ToString().Replace("Фото профиля", "")) + Environment.NewLine;
                }
            else
                for (int i = 0; i < fileList3.Count; i++)
                {
                    textBox2.Text += (fileList3[i].ToString().Replace("Фото профиля", "")) + Environment.NewLine;
                }
        }
    }
}
