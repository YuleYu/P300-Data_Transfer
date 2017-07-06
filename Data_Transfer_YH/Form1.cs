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

namespace Data_Transfer_YH
{
    public partial class Form1 : Form
    {
        private string DSFileName;  // DataSet file name
        private string TSFileName;  // TimeStamp file name

        private TimeStamp[] timeStampSet;
        private string[] HeaderMssg = {
                            "1x1", "2x2","3Fp1","4Fp2","5X3","6X4","7F7","8F3","9Fz","10F4",
                            "11F8","12FT7","13FC3","14Fcz","15Fc4","16FT8","17T3","18C3","19Cz","20C4",
                            "21T4","22TP7","23CP3","24CPz","25CP4","26TP8","27A1","28T5","29P3","30Pz",
                            "31P4","32T6","33A2","34O1","35Oz","36O2","37X5","38X6","39X7","40X8"};     // channel list
            
        private string[] channelFile = {
                            "1", "2","3","4","5","6","7","8","9","10",
                            "11","12","13","14","15","16","17","18","19","20",
                            "21","22","23","24","25","26","27","28","29","30",
                            "31","32","33","34","35","36","37","38","39","40"};     // channel list
        private string[] channel;
        private int channelNum;
        private int[] freLst = { 5, 7, 9, 11, 13, 17, 23 };         // frequency list
        //private int[] freLst = new int[30];
        private int freNum = 0;
        private int expSecend = 8;  // The length of time selected in valid time period, should be set handly.

        private int outFileNum = 0;     // trial times collected from timeStamp file.
        private int recordRate;         // 500,1000... read from .dat file
        private DateTime startTime;

        public Form1()
        {
            InitializeComponent();
            DatasetLocationTextbox.Text = "C:\\Users\\recom\\Desktop\\datFile_saved.dat";
            TimeStampLocationTextbox.Text = "C:\\Users\\recom\\Desktop\\timestamps-14-14-09.txt";
            timeStampSet = new TimeStamp[100];
            //recordRate = Convert.ToInt32(resolutionTextbox.Text);
        }

        private void TimeStampLocationLabel_Click(object sender, EventArgs e){}

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                DSFileName = DatasetLocationTextbox.Text;
                FileStream DSfs = new FileStream(DSFileName, FileMode.Open, FileAccess.Read);
                TSFileName = TimeStampLocationTextbox.Text;
                FileStream TSfs = new FileStream(TSFileName, FileMode.Open, FileAccess.Read);

                StreamReader DSstreamReader = new StreamReader(DSfs);
                StreamReader TSstreamReader = new StreamReader(TSfs);

                if(SeparateTS(ref TSstreamReader))
                {
                    SeparateDS2usfulData(ref DSstreamReader);
                    SeparateDS(ref DSstreamReader);
                }
                else
                {
                    MessageBox.Show("时间戳文件有错！");
                }
                DSstreamReader.Close();
                TSstreamReader.Close();
            }
            catch (FileLoadException) { MessageBox.Show("无法加载文件！"); }
            catch(FileNotFoundException){ MessageBox.Show("未找到文件！"); }
            catch(ArgumentNullException){ MessageBox.Show("未输入文件路径！"); }
            //catch(Exception){ MessageBox.Show("无法转换，出现异常！"); }
            finally { }
        }

        private void DatasetChooseButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog addDatasetDlg = new OpenFileDialog();
            addDatasetDlg.InitialDirectory = "C:";
            addDatasetDlg.Filter = "DataSet File(*.dat)|*.dat";
            if (addDatasetDlg.ShowDialog() == DialogResult.OK)
            {
                DatasetLocationTextbox.Text = addDatasetDlg.FileName;
                DSFileName = DatasetLocationTextbox.Text;
            }
        }

        private void TimeStampChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog addTimestampDlg = new OpenFileDialog();
            addTimestampDlg.InitialDirectory = "C:";
            addTimestampDlg.Filter = "Text(*.txt)|*.txt";
            if (addTimestampDlg.ShowDialog() == DialogResult.OK)
            {
                TimeStampLocationTextbox.Text = addTimestampDlg.FileName;
                TSFileName = TimeStampLocationTextbox.Text;
            }
        }

        private void Trans()
        {
            
        }

        // transfer the TimeStamp text into formatted information.
        private bool SeparateTS(ref StreamReader TSstreamReader)
        {
            string currentLine, tmpStr, tmpName;
            long tmpTime;
            DateTime tmpDateTime;
            //DateTime startTime = new DateTime(2017,7,4,13,52,46);

            char tmpChar;
            int tmpFre;
            outFileNum = 0;

            while ((currentLine = TSstreamReader.ReadLine())!=null)
            {
                int iter = 0;
                //TimeStamp tmpTimeStamp = new TimeStamp();
                int tmpOrder;
                tmpStr = "";
                tmpChar = currentLine[iter++];
                while (tmpChar != ';'){ tmpStr += tmpChar; tmpChar = currentLine[iter++]; }
                tmpOrder = Convert.ToInt32(tmpStr);
                tmpChar = currentLine[iter++]; tmpStr = "";
                while (tmpChar != ';') { tmpStr += tmpChar; tmpChar = currentLine[iter++]; }
                tmpName = tmpStr;
                tmpChar = currentLine[iter++]; tmpStr = "";
                while (tmpChar != ';') { tmpStr += tmpChar; tmpChar = currentLine[iter++]; }
                tmpFre = Convert.ToInt32(tmpStr);
                tmpChar = currentLine[iter++]; tmpStr = "";
                while (iter<currentLine.Length) { tmpStr += tmpChar; tmpChar = currentLine[iter++]; }
                //tmpTime = tmpStr;
                tmpDateTime = Convert.ToDateTime(tmpStr);
                tmpTime = (long)(tmpDateTime - startTime).TotalSeconds;
                System.Console.WriteLine(tmpTime);
                //MessageBox.Show(tmpDateTime);
                TimeStamp tmpTimeStamp = new TimeStamp(tmpOrder, tmpName, tmpFre, tmpTime);
                timeStampSet[outFileNum] = tmpTimeStamp;
                outFileNum++;
            }
            

            if (outFileNum != 0)
            {
                /*freLst[0] = timeStampSet[0].frequency;
                freNum++;
                foreach (TimeStamp ts in timeStampSet)
                {
                    bool ju = true;
                    for (int i=0; i < freNum; i++)
                    {
                        if (ts.frequency == freLst[i])
                        {
                            ju = false;
                            break;
                        }
                    }
                    if (ju) freLst[freNum++] = ts.frequency;
                }*/

                //MessageBox.Show("Ts done!");
                Console.WriteLine("TS done");
                helpMssgLbl.Text = "TS done";
                return true;
            }

           return false;
        }

        private void SeparateDS(ref StreamReader DSstreamReader)
        {
            
            string currentLine, tmpStr;
            char tmpChar;
            
            int iter, currentTrial = 0;
            /*
            SaveFileDialog saveDlg = new SaveFileDialog();
            //saveDlg.InitialDirectory = "C:\\Users\\recom\\Desktop\\transfer_file";
            saveDlg.InitialDirectory = "C:\\Users\\recom\\Desktop\\";
            saveDlg.FileName = "usful_data";
            saveDlg.DefaultExt = "dat";
            */
            StreamReader usfulDataReader = new StreamReader("C:\\Users\\recom\\Desktop\\usful_data");
            //Console.Write("usful data read successful\n");
            Console.WriteLine("usful data read successful");
            helpMssgLbl.Text = "usful data read successful";

            string folderName = @"C:\Users\recom\Desktop\transfer_file";
            if (!File.Exists(folderName)) { Directory.CreateDirectory(folderName); }
            string[] pathStr = new string[channelFile.Count()];
            for (int i=0; i<channelFile.Count(); i++)
            {
                pathStr[i] = Path.Combine(folderName, channelFile[i]);
                Console.WriteLine(pathStr[i]);
                if (!File.Exists(pathStr[i])) Directory.CreateDirectory(pathStr[i]);
            }

            StreamWriter[] saveFileWriter = new StreamWriter[channelFile.Count()*freLst.Count()];
            for (int crrntChannel = 0; crrntChannel < channelFile.Count(); crrntChannel++)
            {
                for (int crrntFre = 0; crrntFre <freLst.Count(); crrntFre++)
                {
                    string path = Path.Combine(pathStr[crrntChannel], freLst[crrntFre].ToString() + "."+saveTypeTextBox.Text.ToString());
                    saveFileWriter[crrntChannel*freLst.Count()+crrntFre] = new StreamWriter(path);
                }
                
            }
            int lineCounter = 0;
         
            while ((currentLine = usfulDataReader.ReadLine()) != null)
            {
                if ((lineCounter++) % (expSecend*recordRate) == 0)
                {
                    currentTrial++;
                }

                tmpStr = "";
                iter = 0;
                int currentChannel = 0;
                while (iter < currentLine.Length)
                {
                    tmpChar = currentLine[iter++];
                    if (tmpChar == '\t')
                    {
                        if (tmpStr != "")
                        {
                            //tmpStr += "\r\n";
                            //string filename = Path.Combine(pathStr[currentChannel], timeStampSet[currentTrial].frequency.ToString() + ".txt");
                            //File.AppendAllText(filename, tmpStr);

                            saveFileWriter[currentChannel* freLst.Count()+ (int)(currentTrial/(Convert.ToInt32(cycleTextbox.Text)+0.001))].WriteLine(tmpStr);
                            //Console.Write("c");
                            currentChannel++;
                            tmpStr = "";
                        }
                        continue;
                    }
                    tmpStr += tmpChar;
                }
            }
            /*
            for (int currentTrial=0; currentTrial < outFileNum; currentTrial++)
            {
                for (int channel = 1; channel <=40; channel++)
                {
                    File.AppendAllLines()
                }
            }
            */
             
            foreach (StreamWriter sw in saveFileWriter)
            {
                sw.Flush();
                sw.Close();
            }
            StreamWriter headerWriter = new StreamWriter(Path.Combine(folderName, "header.txt"));
            foreach(string str in HeaderMssg)
            {
                headerWriter.WriteLine(str);
            }
            headerWriter.Flush();
            headerWriter.Close();

            usfulDataReader.Close();
            //MessageBox.Show("total transfer done");
            Console.WriteLine("total transfer done");
            helpMssgLbl.Text = "total transfer done";
            /*
            while ((currentLine = DSstreamReader.ReadLine()) != null)
            {
                iter = 0;
                tmpStr = "";
                tmpChar = currentLine[iter++];
                while(iter<currentLine.Length)
                {
                    if (tmpChar == ' ')
                    {
                        //tmpStr

                        tmpChar = currentLine[iter++];
                        continue;
                    }
                    tmpStr += tmpChar;
                    tmpChar = currentLine[iter++];
                }

            }*/
        }

        // clear up the useless information in the original data
        private void SeparateDS2usfulData(ref StreamReader DSstreamReader)
        {
            int iter = 1;
            string dayTime, clockTime, currentLine, tmpStr = "";
            while(iter++ < 2) DSstreamReader.ReadLine();   // jump over the title explanation.

            // pick out the time message;
            dayTime = DSstreamReader.ReadLine();        // get month/day/year
            clockTime = DSstreamReader.ReadLine();      // get hour/minute/second
            currentLine = DSstreamReader.ReadLine();    // get channel number
            for (int i=11; i<currentLine.Length; i++) { tmpStr += currentLine[i]; }
            channelNum = Convert.ToInt32(tmpStr);
            currentLine = DSstreamReader.ReadLine();
            tmpStr = "";
            for (int i=7; i < currentLine.Length; i++) { tmpStr += currentLine[i]; }
            recordRate = (int)(Convert.ToDouble(tmpStr));

            calculateStartTime(dayTime, clockTime);


            while (iter++ <15) DSstreamReader.ReadLine();

            StreamWriter saveFileWriter = new StreamWriter("C:\\Users\\recom\\Desktop\\usful_data");
            for (int i = 0; i < outFileNum; i++)
            {
                while (iter++ < (timeStampSet[i].time * recordRate + 250)) // useless data sector
                {
                    DSstreamReader.ReadLine();
                    //Console.WriteLine(DSstreamReader.ReadLine());
                }
                for (int j = 0; j < expSecend * recordRate; j++)
                {
                    saveFileWriter.WriteLine(DSstreamReader.ReadLine());
                    iter++;
                }
                //saveFileWriter.WriteLine("");
            }
            saveFileWriter.Flush();
            saveFileWriter.Close();
            //MessageBox.Show("usful data transfer done");
            Console.WriteLine("usful data transfer done");
            helpMssgLbl.Text = "usful data transfer done";
        }

        private void calculateStartTime(string DayTime, string ClockTime)
        {
            int year, month, day, hour, minute, second;
            string tmpStr;
            tmpStr = ""; for (int i = 7; i <= 8; i++) { tmpStr += DayTime[i]; }
            month = Convert.ToInt32(tmpStr);
            tmpStr = ""; for (int i = 10; i <= 11; i++) { tmpStr += DayTime[i]; }
            day = Convert.ToInt32(tmpStr);
            tmpStr = ""; for (int i = 13; i <= 16; i++) { tmpStr += DayTime[i]; }
            year = Convert.ToInt32(tmpStr);
            tmpStr = ""; for (int i = 7; i <= 8; i++) { tmpStr += ClockTime[i]; }
            hour = Convert.ToInt32(tmpStr);    // 因为都是下午做的实验，不确定在上午"时"是否会变为一位数。
            tmpStr = ""; for (int i = 10; i <= 11; i++) { tmpStr += ClockTime[i]; }
            minute = Convert.ToInt32(tmpStr);
            tmpStr = ""; for (int i = 13; i <= 14; i++) { tmpStr += ClockTime[i]; }
            second = Convert.ToInt32(tmpStr);
            DateTime endTime = new DateTime(year, month, day, hour, minute, second);

            //string[] rowCounter = File.ReadAllLines(DSFileName);
            //DateTime continueTime = new DateTime(0,0,0,)
            int continueTime = (lineCounter()-14)/recordRate;
            //Console.WriteLine(recordRate);
            Console.WriteLine(continueTime);
            year = month = day = hour = minute = second = 0;
            second = continueTime % 60;
            Console.WriteLine(second);
            minute = continueTime / 60;
            if (minute > 60)
            {
                hour = minute / 60;
                minute = minute % 60;
            }
            Console.WriteLine(minute);
            if (hour>24)
            {
                day = hour / 24;
                hour = hour % 24;
            }// there should be no one experimenting continually more than one month???... 
            Console.WriteLine(hour);
            TimeSpan cntnTime = new TimeSpan(day, hour, minute, second);
            Console.WriteLine(cntnTime);

            startTime = endTime - cntnTime;
            Console.Write(startTime);
        }

        private void goPassStream(ref StreamReader sr, int passLineNum) { }

        private int lineCounter()
        {
            FileStream DSfs = new FileStream(DSFileName, FileMode.Open, FileAccess.Read);
            StreamReader DSstreamReader = new StreamReader(DSfs);
            int counter = 0;
            while (DSstreamReader.ReadLine() != null) { counter++; }

            return counter;
        }
    }
}
