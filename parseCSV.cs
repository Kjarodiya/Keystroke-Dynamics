#region
using System;
using System.IO; // This is required for File I/O
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion


namespace ProgrammingAssignmentCSCI860M011155058
public class parseCSV
{
	public parseCSV()
	{
        Static void main()
        {
            #region Static double arrays for storing a value from data files
            static double[,] s002; // Subject 1 - s002.csv
            static double[,] s003; // Subject 2 - s003.csv
            static double[,] s004; // Subject 3 - s004.csv
            static double[,] s005; // Subject 4 - s005.csv
            static double[,] s007; // Subject 5 - s007.csv
            static double[,] s008; // Subject 6 - s008.csv
            static double[,] s010; // Subject 7 - s010.csv
            static double[,] s011; // Subject 8 - s011.csv
            static double[,] s012; // Subject 9 - s012.csv
            static double[,] s013; // Subject 10 - s013.csv
            static double[,] s015; // Subject 11 - s015.csv
            static double[,] s016; // Subject 12 - s016.csv
            static double[,] s017; // Subject 13 - s017.csv
            static double[,] s018; // Subject 14 - s018.csv
            static double[,] s019; // Subject 15 - s019.csv
            static double[,] s020; // Subject 16 - s020.csv
            static double[,] s021; // Subject 17 - s021.csv
            static double[,] s022; // Subject 18 - s022.csv
            static double[,] s024; // Subject 19 - s024.csv
            static double[,] s025; // Subject 20 - s025.csv
            static double[,] s026; // Subject 21 - s026.csv
            static double[,] s027; // Subject 22 - s027.csv
            static double[,] s028; // Subject 23 - s028.csv
            static double[,] s029; // Subject 24 - s029.csv
            static double[,] s030; // Subject 25 - s030.csv
            static double[,] s031; // Subject 26 - s031.csv
            static double[,] s032; // Subject 27 - s032.csv
            static double[,] s033; // Subject 28 - s033.csv
            static double[,] s034; // Subject 29 - s034.csv
            static double[,] s035; // Subject 30 - s035.csv
            static double[,] s036; // Subject 31 - s036.csv
            static double[,] s037; // Subject 32 - s037.csv
            static double[,] s038; // Subject 33 - s038.csv
            static double[,] s039; // Subject 34 - s039.csv
            static double[,] s040; // Subject 35 - s040.csv
            static double[,] s041; // Subject 36 - s041.csv
            static double[,] s042; // Subject 37 - s042.csv
            static double[,] s043; // Subject 38 - s043.csv
            static double[,] s044; // Subject 39 - s044.csv
            static double[,] s046; // Subject 40 - s046.csv
            static double[,] s047; // Subject 41 - s047.csv
            static double[,] s048; // Subject 42 - s048.csv
            static double[,] s049; // Subject 43 - s049.csv
            static double[,] s050; // Subject 44 - s050.csv
            static double[,] s051; // Subject 45 - s051.csv
            static double[,] s052; // Subject 46 - s052.csv
            static double[,] s053; // Subject 47 - s053.csv
            static double[,] s054; // Subject 48 - s054.csv
            static double[,] s055; // Subject 49 - s055.csv
            static double[,] s056; // Subject 50 - s056.csv
            static double[,] s057; // Subject 51 - s057.csv
            #endregion

            #region Header
            // Title of Application 
            Console.Write("---------------------------------------Programming Assignment 1--------------------------------------" + Environment.NewLine + "-------------------CSCI-860-M01: Biometrics and its Applications in Special Topics------------------" + Environment.NewLine);

            // Sub Title
            Console.Write("-------------------------------------Kinjal Jarodiya(1155058)----------------------------------------" + Environment.NewLine);

            Console.Write(" Selcet Subject between 1 to 51 :: ");
            #endregion

            parseCSV parseCSV = new parseCSV();


            #region Parsing data
            s002 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s002.csv");
            s003 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s003.csv");
            s004 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s004.csv");
            s005 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s005.csv");
            s007 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s007.csv");
            s008 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s008.csv");
            s010 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s010.csv");
            s011 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s011.csv");
            s012 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s012.csv");
            s013 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s013.csv");
            s015 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s015.csv");
            s016 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s016.csv");
            s017 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s017.csv");
            s018 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s018.csv");
            s019 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s019.csv");
            s020 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s020.csv");
            s021 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s021.csv");
            s022 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s022.csv");
            s024 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s024.csv");
            s025 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s025.csv");
            s026 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s026.csv");
            s027 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s027.csv");
            s028 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s028.csv");
            s029 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s029.csv");
            s030 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s030.csv");
            s031 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s031.csv");
            s032 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s032.csv");
            s033 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s033.csv");
            s034 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s034.csv");
            s035 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s035.csv");
            s036 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s036.csv");
            s037 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s037.csv");
            s038 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s038.csv");
            s039 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s039.csv");
            s040 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s040.csv");
            s041 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s041.csv");
            s042 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s042.csv");
            s043 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s042.csv");
            s044 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s044.csv");
            s046 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s046.csv");
            s047 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s047.csv");
            s048 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s042.csv");
            s049 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s049.csv");
            s050 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s050.csv");
            s051 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s051.csv");
            s052 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s052.csv");
            s053 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s053.csv");
            s054 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s054.csv");
            s055 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s055.csv");
            s056 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s056.csv");
            s057 = ParseData(@"C:\Subjects\kinja\source\repos\ProgrammingAssignmentCSCI860M011155058\ProgrammingAssignmentCSCI860M011155058\Data Files\s057.csv");
            #endregion

            #region Set values to parseCSV object
            parseCSV.setValue(s002);
            parseCSV.setValue(s003);
            parseCSV.setValue(s004);
            parseCSV.setValue(s005);
            parseCSV.setValue(s007);
            parseCSV.setValue(s008);
            parseCSV.setValue(s010);
            parseCSV.setValue(s011);
            parseCSV.setValue(s012);
            parseCSV.setValue(s013);
            parseCSV.setValue(s015);
            parseCSV.setValue(s016);
            parseCSV.setValue(s017);
            parseCSV.setValue(s018);
            parseCSV.setValue(s019);
            parseCSV.setValue(s020);
            parseCSV.setValue(s021);
            parseCSV.setValue(s022);
            parseCSV.setValue(s024);
            parseCSV.setValue(s025);
            parseCSV.setValue(s026);
            parseCSV.setValue(s027);
            parseCSV.setValue(s028);
            parseCSV.setValue(s029);
            parseCSV.setValue(s030);
            parseCSV.setValue(s031);
            parseCSV.setValue(s032);
            parseCSV.setValue(s033);
            parseCSV.setValue(s034);
            parseCSV.setValue(s035);
            parseCSV.setValue(s036);
            parseCSV.setValue(s037);
            parseCSV.setValue(s038);
            parseCSV.setValue(s039);
            parseCSV.setValue(s040);
            parseCSV.setValue(s041);
            parseCSV.setValue(s042);
            parseCSV.setValue(s043);
            parseCSV.setValue(s044);
            parseCSV.setValue(s046);
            parseCSV.setValue(s047);
            parseCSV.setValue(s048);
            parseCSV.setValue(s049);
            parseCSV.setValue(s050);
            parseCSV.setValue(s051);
            parseCSV.setValue(s052);
            parseCSV.setValue(s053);
            parseCSV.setValue(s054);
            parseCSV.setValue(s055);
            parseCSV.setValue(s056);
            parseCSV.setValue(s057);
            #endregion


        }

    }
}
