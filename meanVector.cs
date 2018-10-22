#region
using System;
using System.IO; // This is required for File I/O
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion


namespace ProgrammingAssignmentCSCI860M011155058
public class meanVector
{
    public meanVector()
    {
        Static void main()
        {
            #region Static double array to store mean of Key hold and Key inetrval of all test
            static double[] mean_s002; // Subject 1
            static double[] mean_s003; // Subject 2
            static double[] mean_s004; // Subject 3
            static double[] mean_s005; // Subject 4
            static double[] mean_s007; // Subject 5
            static double[] mean_s008; // Subject 6
            static double[] mean_s010; // Subject 7
            static double[] mean_s011; // Subject 8
            static double[] mean_s012; // Subject 9
            static double[] mean_s013; // Subject 10
            static double[] mean_s015; // Subject 11
            static double[] mean_s016; // Subject 12
            static double[] mean_s017; // Subject 13
            static double[] mean_s018; // Subject 14
            static double[] mean_s019; // Subject 15
            static double[] mean_s020; // Subject 16
            static double[] mean_s021; // Subject 17
            static double[] mean_s022; // Subject 18
            static double[] mean_s024; // Subject 19
            static double[] mean_s025; // Subject 20
            static double[] mean_s026; // Subject 21
            static double[] mean_s027; // Subject 22
            static double[] mean_s028; // Subject 23
            static double[] mean_s029; // Subject 24
            static double[] mean_s030; // Subject 25
            static double[] mean_s031; // Subject 26
            static double[] mean_s032; // Subject 27
            static double[] mean_s033; // Subject 28
            static double[] mean_s034; // Subject 29
            static double[] mean_s035; // Subject 30
            static double[] mean_s036; // Subject 31
            static double[] mean_s037; // Subject 32
            static double[] mean_s038; // Subject 33
            static double[] mean_s039; // Subject 34
            static double[] mean_s040; // Subject 35
            static double[] mean_s041; // Subject 36
            static double[] mean_s042; // Subject 37
            static double[] mean_s043; // Subject 38
            static double[] mean_s044; // Subject 39
            static double[] mean_s046; // Subject 40
            static double[] mean_s047; // Subject 41
            static double[] mean_s048; // Subject 42
            static double[] mean_s049; // Subject 43
            static double[] mean_s050; // Subject 44
            static double[] mean_s051; // Subject 45
            static double[] mean_s052; // Subject 46
            static double[] mean_s053; // Subject 47
            static double[] mean_s054; // Subject 48
            static double[] mean_s055; // Subject 49
            static double[] mean_s056; // Subject 50
            static double[] mean_s057; // Subject 51
            #endregion

            #region Static two-Dimentional double arrays that will be used for calculating genuine and impostor score
            static double[,] s002_Test; // Subject 1
            static double[,] s003_Test; // Subject 2
            static double[,] s004_Test; // Subject 3
            static double[,] s005_Test; // Subject 4
            static double[,] s007_Test; // Subject 5
            static double[,] s008_Test; // Subject 6
            static double[,] s010_Test; // Subject 7
            static double[,] s011_Test; // Subject 8
            static double[,] s012_Test; // Subject 9
            static double[,] s013_Test; // Subject 10
            static double[,] s015_Test; // Subject 11
            static double[,] s016_Test; // Subject 12
            static double[,] s017_Test; // Subject 13
            static double[,] s018_Test; // Subject 14
            static double[,] s019_Test; // Subject 15
            static double[,] s020_Test; // Subject 16
            static double[,] s021_Test; // Subject 17
            static double[,] s022_Test; // Subject 18
            static double[,] s024_Test; // Subject 19
            static double[,] s025_Test; // Subject 20
            static double[,] s026_Test; // Subject 21
            static double[,] s027_Test; // Subject 22
            static double[,] s028_Test; // Subject 23
            static double[,] s029_Test; // Subject 24
            static double[,] s030_Test; // Subject 25
            static double[,] s031_Test; // Subject 26
            static double[,] s032_Test; // Subject 27
            static double[,] s033_Test; // Subject 28
            static double[,] s034_Test; // Subject 29
            static double[,] s035_Test; // Subject 30
            static double[,] s036_Test; // Subject 31
            static double[,] s037_Test; // Subject 32
            static double[,] s038_Test; // Subject 33
            static double[,] s039_Test; // Subject 34
            static double[,] s040_Test; // Subject 35
            static double[,] s041_Test; // Subject 36
            static double[,] s042_Test; // Subject 37
            static double[,] s043_Test; // Subject 38
            static double[,] s044_Test; // Subject 39
            static double[,] s046_Test; // Subject 40
            static double[,] s047_Test; // Subject 41
            static double[,] s048_Test; // Subject 42
            static double[,] s049_Test; // Subject 43
            static double[,] s050_Test; // Subject 44
            static double[,] s051_Test; // Subject 45
            static double[,] s052_Test; // Subject 46
            static double[,] s053_Test; // Subject 47
            static double[,] s054_Test; // Subject 48
            static double[,] s055_Test; // Subject 49
            static double[,] s056_Test; // Subject 50
            static double[,] s057_Test; // Subject 51
            #endregion

            #region Static double arrays that represent the genuine Score vectors
            static double[,] s002_Genuine;
            static double[,] s003_Genuine;
            static double[,] s004_Genuine;
            static double[,] s005_Genuine;
            static double[,] s007_Genuine;
            static double[,] s008_Genuine;
            static double[,] s010_Genuine;
            static double[,] s011_Genuine;
            static double[,] s012_Genuine;
            static double[,] s013_Genuine;
            static double[,] s015_Genuine;
            static double[,] s016_Genuine;
            static double[,] s017_Genuine;
            static double[,] s018_Genuine;
            static double[,] s019_Genuine;
            static double[,] s020_Genuine;
            static double[,] s021_Genuine;
            static double[,] s022_Genuine;
            static double[,] s024_Genuine;
            static double[,] s025_Genuine;
            static double[,] s026_Genuine;
            static double[,] s027_Genuine;
            static double[,] s028_Genuine;
            static double[,] s029_Genuine;
            static double[,] s030_Genuine;
            static double[,] s031_Genuine;
            static double[,] s032_Genuine;
            static double[,] s033_Genuine;
            static double[,] s034_Genuine;
            static double[,] s035_Genuine;
            static double[,] s036_Genuine;
            static double[,] s037_Genuine;
            static double[,] s038_Genuine;
            static double[,] s039_Genuine;
            static double[,] s040_Genuine;
            static double[,] s041_Genuine;
            static double[,] s042_Genuine;
            static double[,] s043_Genuine;
            static double[,] s044_Genuine;
            static double[,] s046_Genuine;
            static double[,] s047_Genuine;
            static double[,] s048_Genuine;
            static double[,] s049_Genuine;
            static double[,] s050_Genuine;
            static double[,] s051_Genuine;
            static double[,] s052_Genuine;
            static double[,] s053_Genuine;
            static double[,] s054_Genuine;
            static double[,] s055_Genuine;
            static double[,] s056_Genuine;
            static double[,] s057_Genuine;
            #endregion
            #region For Subject 1
            if (subjectNumber == "1")
            {
                Console.Write("Enter the value of N : Either  100 or 200 or 300  ::" + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s002_Samples = RetriveTrainningVector(s002, N);

                    mean_s002 = calcTemplateVector(s002_Samples, N);

                    s002_Test = retriveTestVector(s002, N);

                    s002_Genuine = calcGenuineScore(s002_Test, mean_s002, N);

                    #region Extracting all samples to calculate impostor rates
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    // Create a method to calculate the zero-effort impostor scores
                    FindIPRosterRate(s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s002);

                    FalseRejectRate(s002_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.WriteLine("N is very large, Exit the Program");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 2
            if (subjectNumber == "2")
            {
                Console.Write("Enter the number of samples either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s003_Samples = RetriveTrainningVector(s003, N);

                    mean_s003 = calcTemplateVector(s003_Samples, N);

                    s003_Test = retriveTestVector(s003, N);

                    s003_Genuine = calcGenuineScore(s003_Test, mean_s003, N);

                    #region Test samples for impostor scores
                    // Retriving the test samples for Calculating impostor Score
                    s002_Test = retriveTestVector(s002, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s003);

                    FalseRejectRate(s003_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.Write("The sample size N is too large, the Exit the program.");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 3
            if (subjectNumber == "3")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300." + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s004_Samples = RetriveTrainningVector(s004, N);

                    mean_s004 = calcTemplateVector(s004_Samples, N);

                    s004_Test = retriveTestVector(s004, N);

                    #region Retriving Sample for calculating impostor scores
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    s004_Genuine = calcGenuineScore(s004_Test, mean_s004, N);

                    FindIPRosterRate(s002_Test, s003_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s004);

                    FalseRejectRate(s004_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.Write("Your input is too Large, Exit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 4
            if (subjectNumber == "4")
            {

                Console.Write("Enter the number of Sample N either 100 0r 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);


                    double[,] s005_Samples = RetriveTrainningVector(s005, N);

                    mean_s005 = calcTemplateVector(s005_Samples, N);

                    s005_Test = retriveTestVector(s005, N);

                    s005_Genuine = calcGenuineScore(s005_Test, mean_s005, N);

                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s005);

                    FalseRejectRate(s005_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.WriteLine("Your input sample sizde is too large, Exit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 5
            if (subjectNumber == "5")
            {

                Console.Write("Enter N: The number of samples.  Value of N can either be 100, 200, or 300." + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                // The code to execute when the number of samples equals one of the three options
                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s007_Samples = RetriveTrainningVector(s007, N);

                    mean_s007 = calcTemplateVector(s007_Samples, N);
                    s007_Test = retriveTestVector(s007, N);

                    s007_Genuine = calcGenuineScore(s007_Test, mean_s007, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s007);

                    FalseRejectRate(s007_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 6
            if (subjectNumber == "6")
            {
                // Prompting the Subject to enter the number of samples
                Console.Write("Enter N:  The number of samples. Value of N can be either 100, 200, or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s008_Samples = RetriveTrainningVector(s008, N);

                    mean_s008 = calcTemplateVector(s008_Samples, N);

                    s008_Test = retriveTestVector(s008, N);

                    s008_Genuine = calcGenuineScore(s008_Test, mean_s008, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s008);

                    FalseRejectRate(s008_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 7
            if (subjectNumber == "7")
            {

                Console.Write("Enter the number of Sample N either 100 0r 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s010_Samples = RetriveTrainningVector(s010, N);

                    mean_s010 = calcTemplateVector(s010_Samples, N);

                    s010_Test = retriveTestVector(s010, N);

                    s010_Genuine = calcGenuineScore(s010_Test, mean_s010, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s010);

                    FalseRejectRate(s010_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 8
            if (subjectNumber == "8")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s011_Samples = RetriveTrainningVector(s011, N);

                    mean_s011 = calcTemplateVector(s011_Samples, N);

                    s011_Test = retriveTestVector(s011, N);
                    s011_Genuine = calcGenuineScore(s011_Test, mean_s011, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s011);

                    FalseRejectRate(s011_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 9
            if (subjectNumber == "9")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s012_Samples = RetriveTrainningVector(s012, N);

                    mean_s012 = calcTemplateVector(s012_Samples, N);

                    s012_Test = retriveTestVector(s012, N);

                    s012_Genuine = calcGenuineScore(s012_Test, mean_s012, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s012);

                    FalseRejectRate(s012_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 10
            if (subjectNumber == "10")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s013_Samples = RetriveTrainningVector(s013, N);

                    mean_s013 = calcTemplateVector(s013_Samples, N);

                    s013_Test = retriveTestVector(s013, N);

                    s013_Genuine = calcGenuineScore(s013_Test, mean_s013, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s013);

                    FalseRejectRate(s013_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 11
            if (subjectNumber == "11")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s015_Samples = RetriveTrainningVector(s015, N);

                    mean_s015 = calcTemplateVector(s015_Samples, N);

                    s015_Test = retriveTestVector(s015, N);
                    s015_Genuine = calcGenuineScore(s015_Test, mean_s015, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s015);

                    FalseRejectRate(s015_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 12
            if (subjectNumber == "12")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s016_Samples = RetriveTrainningVector(s016, N);

                    mean_s016 = calcTemplateVector(s016_Samples, N);

                    s016_Test = retriveTestVector(s016, N);
                    s016_Genuine = calcGenuineScore(s016_Test, mean_s016, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s016);

                    FalseRejectRate(s016_Genuine, N);
                }

                else if (enterN != "100" || enterN != "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 13
            if (subjectNumber == "13")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s017_Samples = RetriveTrainningVector(s017, N);

                    mean_s017 = calcTemplateVector(s017_Samples, N);

                    s017_Test = retriveTestVector(s017, N);

                    s017_Genuine = calcGenuineScore(s017_Test, mean_s017, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s017);

                    FalseRejectRate(s017_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 14
            if (subjectNumber == "14")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s018_Samples = RetriveTrainningVector(s018, N);

                    mean_s018 = calcTemplateVector(s018_Samples, N);

                    s018_Test = retriveTestVector(s018, N);
                    s018_Genuine = calcGenuineScore(s018_Test, mean_s018, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s018);

                    FalseRejectRate(s018_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 15
            if (subjectNumber == "15")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s019_Samples = RetriveTrainningVector(s019, N);

                    mean_s019 = calcTemplateVector(s019_Samples, N);

                    s019_Test = retriveTestVector(s019, N);
                    s019_Genuine = calcGenuineScore(s019_Test, mean_s019, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s019);

                    FalseRejectRate(s019_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 16
            if (subjectNumber == "16")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s020_Samples = RetriveTrainningVector(s020, N);

                    mean_s020 = calcTemplateVector(s020_Samples, N);

                    s020_Test = retriveTestVector(s020, N);

                    s020_Genuine = calcGenuineScore(s020_Test, mean_s020, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s020);

                    FalseRejectRate(s020_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 17
            if (subjectNumber == "17")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s021_Samples = RetriveTrainningVector(s021, N);

                    mean_s021 = calcTemplateVector(s021_Samples, N);

                    s021_Test = retriveTestVector(s021, N);

                    s021_Genuine = calcGenuineScore(s021_Test, mean_s021, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s021);

                    FalseRejectRate(s021_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 18
            if (subjectNumber == "18")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s022_Samples = RetriveTrainningVector(s022, N);

                    mean_s022 = calcTemplateVector(s022_Samples, N);

                    s022_Test = retriveTestVector(s022, N);

                    s022_Genuine = calcGenuineScore(s022_Test, mean_s022, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s022);

                    FalseRejectRate(s022_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 19
            if (subjectNumber == "19")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s024_Samples = RetriveTrainningVector(s024, N);

                    mean_s024 = calcTemplateVector(s024_Samples, N);

                    s024_Test = retriveTestVector(s024, N);

                    s024_Genuine = calcGenuineScore(s024_Test, mean_s024, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s024);

                    FalseRejectRate(s024_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 20
            if (subjectNumber == "20")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s025_Samples = RetriveTrainningVector(s025, N);

                    mean_s025 = calcTemplateVector(s025_Samples, N);

                    s025_Test = retriveTestVector(s025, N);

                    s025_Genuine = calcGenuineScore(s025_Test, mean_s025, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s025);

                    FalseRejectRate(s025_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 21
            if (subjectNumber == "21")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s026_Samples = RetriveTrainningVector(s026, N);

                    mean_s026 = calcTemplateVector(s026_Samples, N);

                    s026_Test = retriveTestVector(s026, N);

                    s026_Genuine = calcGenuineScore(s026_Test, mean_s026, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s026);

                    FalseRejectRate(s026_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 22
            if (subjectNumber == "22")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s027_Samples = RetriveTrainningVector(s027, N);

                    mean_s027 = calcTemplateVector(s027_Samples, N);

                    s027_Test = retriveTestVector(s027, N);

                    s027_Genuine = calcGenuineScore(s027_Test, mean_s027, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s027);

                    FalseRejectRate(s027_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 23
            if (subjectNumber == "23")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s028_Samples = RetriveTrainningVector(s028, N);

                    mean_s028 = calcTemplateVector(s028_Samples, N);

                    s028_Test = retriveTestVector(s028, N);

                    s028_Genuine = calcGenuineScore(s028_Test, mean_s028, N);

                    #region Extracting all the samples for the impostor calculation
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s028);

                    FalseRejectRate(s028_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 24
            if (subjectNumber == "24")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s029_Samples = RetriveTrainningVector(s029, N);

                    mean_s029 = calcTemplateVector(s029_Samples, N);

                    s029_Test = retriveTestVector(s029, N);

                    s029_Genuine = calcGenuineScore(s029_Test, mean_s029, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s029);

                    FalseRejectRate(s029_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 25
            if (subjectNumber == "25")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s030_Samples = RetriveTrainningVector(s030, N);

                    mean_s030 = calcTemplateVector(s030_Samples, N);

                    s030_Test = retriveTestVector(s030, N);

                    s030_Genuine = calcGenuineScore(s030_Test, mean_s030, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s030);

                    FalseRejectRate(s030_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 26
            if (subjectNumber == "26")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s031_Samples = RetriveTrainningVector(s031, N);

                    mean_s031 = calcTemplateVector(s031_Samples, N);

                    s031_Test = retriveTestVector(s031, N);

                    s031_Genuine = calcGenuineScore(s031_Test, mean_s031, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s027_Test, s026_Test, s028_Test, s029_Test, s030_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s031);

                    FalseRejectRate(s031_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 27
            if (subjectNumber == "27")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s032_Samples = RetriveTrainningVector(s032, N);

                    mean_s032 = calcTemplateVector(s032_Samples, N);

                    s032_Test = retriveTestVector(s032, N);

                    s032_Genuine = calcGenuineScore(s032_Test, mean_s032, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s032);

                    FalseRejectRate(s032_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 28
            if (subjectNumber == "28")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s033_Samples = RetriveTrainningVector(s033, N);

                    mean_s033 = calcTemplateVector(s033_Samples, N);

                    s033_Test = retriveTestVector(s033, N);

                    s033_Genuine = calcGenuineScore(s033_Test, mean_s033, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s033);

                    FalseRejectRate(s033_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 29
            if (subjectNumber == "29")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s034_Samples = RetriveTrainningVector(s034, N);

                    mean_s034 = calcTemplateVector(s034_Samples, N);

                    s034_Test = retriveTestVector(s034, N);

                    s034_Genuine = calcGenuineScore(s034_Test, mean_s034, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s034);

                    FalseRejectRate(s034_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 30
            if (subjectNumber == "30")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s035_Samples = RetriveTrainningVector(s035, N);

                    mean_s035 = calcTemplateVector(s035_Samples, N);

                    s035_Test = retriveTestVector(s035, N);

                    s035_Genuine = calcGenuineScore(s035_Test, mean_s035, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s035);

                    FalseRejectRate(s035_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 31
            if (subjectNumber == "31")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s036_Samples = RetriveTrainningVector(s036, N);

                    mean_s036 = calcTemplateVector(s036_Samples, N);

                    s036_Test = retriveTestVector(s036, N);

                    s036_Genuine = calcGenuineScore(s036_Test, mean_s036, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s036);

                    FalseRejectRate(s036_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 32
            if (subjectNumber == "32")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s037_Samples = RetriveTrainningVector(s037, N);

                    mean_s037 = calcTemplateVector(s037_Samples, N);

                    s037_Test = retriveTestVector(s037, N);

                    s037_Genuine = calcGenuineScore(s037_Test, mean_s037, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s037);

                    FalseRejectRate(s037_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 33
            if (subjectNumber == "33")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s038_Samples = RetriveTrainningVector(s038, N);

                    mean_s038 = calcTemplateVector(s038_Samples, N);

                    s038_Test = retriveTestVector(s038, N);

                    s038_Genuine = calcGenuineScore(s039_Test, mean_s038, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s038);

                    FalseRejectRate(s038_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 34
            if (subjectNumber == "34")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s039_Samples = RetriveTrainningVector(s039, N);

                    mean_s039 = calcTemplateVector(s039_Samples, N);

                    s039_Test = retriveTestVector(s039, N);

                    s039_Genuine = calcGenuineScore(s039_Test, mean_s039, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s039);

                    FalseRejectRate(s039_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 35
            if (subjectNumber == "35")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s040_Samples = RetriveTrainningVector(s040, N);

                    mean_s040 = calcTemplateVector(s040_Samples, N);

                    s040_Test = retriveTestVector(s040, N);
                    s040_Genuine = calcGenuineScore(s040_Test, mean_s040, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s040);

                    FalseRejectRate(s040_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 36
            if (subjectNumber == "36")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s041_Samples = RetriveTrainningVector(s041, N);

                    mean_s041 = calcTemplateVector(s041_Samples, N);

                    s041_Test = retriveTestVector(s041, N);

                    s041_Genuine = calcGenuineScore(s041_Test, mean_s041, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s041);

                    FalseRejectRate(s041_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 37
            if (subjectNumber == "37")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s042_Samples = RetriveTrainningVector(s042, N);

                    mean_s042 = calcTemplateVector(s042_Samples, N);

                    s042_Test = retriveTestVector(s042, N);

                    s042_Genuine = calcGenuineScore(s042_Test, mean_s042, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s042);

                    FalseRejectRate(s042_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 38
            if (subjectNumber == "38")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s043_Samples = RetriveTrainningVector(s043, N);

                    mean_s043 = calcTemplateVector(s043_Samples, N);

                    s043_Test = retriveTestVector(s043, N);

                    s043_Genuine = calcGenuineScore(s043_Test, mean_s043, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s043);

                    FalseRejectRate(s043_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 39
            if (subjectNumber == "39")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s044_Samples = RetriveTrainningVector(s044, N);

                    mean_s044 = calcTemplateVector(s044_Samples, N);

                    s044_Test = retriveTestVector(s044, N);

                    s044_Genuine = calcGenuineScore(s004_Test, mean_s044, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s044);

                    FalseRejectRate(s044_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 40
            if (subjectNumber == "40")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s046_Samples = RetriveTrainningVector(s046, N);

                    mean_s046 = calcTemplateVector(s046_Samples, N);

                    s046_Test = retriveTestVector(s046, N);

                    s046_Genuine = calcGenuineScore(s046_Test, mean_s046, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s046);

                    FalseRejectRate(s046_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 41
            if (subjectNumber == "41")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s047_Samples = RetriveTrainningVector(s047, N);

                    mean_s047 = calcTemplateVector(s047_Samples, N);

                    s047_Test = retriveTestVector(s047, N);

                    s047_Genuine = calcGenuineScore(s047_Test, mean_s047, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s047);

                    FalseRejectRate(s047_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 42
            if (subjectNumber == "42")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s048_Samples = RetriveTrainningVector(s048, N);

                    mean_s048 = calcTemplateVector(s048_Samples, N);

                    s048_Test = retriveTestVector(s048, N);

                    s048_Genuine = calcGenuineScore(s048_Test, mean_s048, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion


                    // Method calls to calculate the impostor scores and the False Reject Rates.  
                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s048);

                    FalseRejectRate(s048_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 43
            if (subjectNumber == "43")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s049_Samples = RetriveTrainningVector(s049, N);

                    mean_s049 = calcTemplateVector(s049_Samples, N);

                    s049_Test = retriveTestVector(s049, N);

                    s049_Genuine = calcGenuineScore(s049_Test, mean_s049, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s049);

                    FalseRejectRate(s049_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 44
            if (subjectNumber == "44")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s050_Samples = RetriveTrainningVector(s050, N);

                    mean_s050 = calcTemplateVector(s050_Samples, N);

                    s050_Test = retriveTestVector(s050, N);

                    s050_Genuine = calcGenuineScore(s050_Test, mean_s050, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s050);

                    FalseRejectRate(s050_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 45
            if (subjectNumber == "45")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s051_Samples = RetriveTrainningVector(s051, N);

                    mean_s051 = calcTemplateVector(s051_Samples, N);

                    s051_Test = retriveTestVector(s051, N);

                    s051_Genuine = calcGenuineScore(s051_Test, mean_s051, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s002);

                    FalseRejectRate(s051_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 46
            if (subjectNumber == "46")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s052_Samples = RetriveTrainningVector(s052, N);

                    mean_s052 = calcTemplateVector(s052_Samples, N);

                    s052_Test = retriveTestVector(s052, N);

                    s052_Genuine = calcGenuineScore(s052_Test, mean_s052, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s053_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s052);

                    FalseRejectRate(s052_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 47
            if (subjectNumber == "47")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s053_Samples = RetriveTrainningVector(s053, N);

                    mean_s053 = calcTemplateVector(s053_Samples, N);

                    s053_Test = retriveTestVector(s053, N);

                    s053_Genuine = calcGenuineScore(s053_Test, mean_s053, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s054_Test, s055_Test, s056_Test, s057_Test, N, mean_s053);

                    FalseRejectRate(s053_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 48
            if (subjectNumber == "48")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s054_Samples = RetriveTrainningVector(s054, N);

                    mean_s054 = calcTemplateVector(s054_Samples, N);

                    s054_Test = retriveTestVector(s054, N);

                    s054_Genuine = calcGenuineScore(s054_Test, mean_s054, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s055_Test, s056_Test, s057_Test, N, mean_s054);

                    FalseRejectRate(s054_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 49
            if (subjectNumber == "49")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s055_Samples = RetriveTrainningVector(s055, N);

                    mean_s055 = calcTemplateVector(s055_Samples, N);

                    s055_Test = retriveTestVector(s055, N);

                    s055_Genuine = calcGenuineScore(s055_Test, mean_s055, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s056_Test = retriveTestVector(s056, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s056_Test, s057_Test, N, mean_s055);

                    FalseRejectRate(s055_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 50
            if (subjectNumber == "50")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s056_Samples = RetriveTrainningVector(s056, N);

                    mean_s056 = calcTemplateVector(s056_Samples, N);

                    s056_Test = retriveTestVector(s056, N);

                    s056_Genuine = calcGenuineScore(s056_Test, mean_s056, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s057_Test = retriveTestVector(s057, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s057_Test, N, mean_s056);

                    FalseRejectRate(s056_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            #endregion

            #region For Subject 51
            if (subjectNumber == "51")
            {
                Console.Write("Enter the number of samples N either 100 or 200 or 300" + Environment.NewLine + "N = ");
                string enterN = Console.ReadLine();

                if (enterN == "100" || enterN == "200" || enterN == "300")
                {
                    int N = int.Parse(enterN);

                    double[,] s057_Samples = RetriveTrainningVector(s057, N);

                    mean_s057 = calcTemplateVector(s057_Samples, N);
                    s057_Test = retriveTestVector(s057, N);

                    s057_Genuine = calcGenuineScore(s057_Test, mean_s057, N);

                    #region Retrive the sample for calculating IPRoster Score
                    s002_Test = retriveTestVector(s002, N);
                    s003_Test = retriveTestVector(s003, N);
                    s004_Test = retriveTestVector(s004, N);
                    s005_Test = retriveTestVector(s005, N);
                    s007_Test = retriveTestVector(s007, N);
                    s008_Test = retriveTestVector(s008, N);
                    s010_Test = retriveTestVector(s010, N);
                    s011_Test = retriveTestVector(s011, N);
                    s012_Test = retriveTestVector(s012, N);
                    s013_Test = retriveTestVector(s013, N);
                    s015_Test = retriveTestVector(s015, N);
                    s016_Test = retriveTestVector(s016, N);
                    s017_Test = retriveTestVector(s017, N);
                    s018_Test = retriveTestVector(s018, N);
                    s019_Test = retriveTestVector(s019, N);
                    s020_Test = retriveTestVector(s020, N);
                    s021_Test = retriveTestVector(s021, N);
                    s022_Test = retriveTestVector(s022, N);
                    s024_Test = retriveTestVector(s024, N);
                    s025_Test = retriveTestVector(s025, N);
                    s026_Test = retriveTestVector(s026, N);
                    s027_Test = retriveTestVector(s027, N);
                    s028_Test = retriveTestVector(s028, N);
                    s029_Test = retriveTestVector(s029, N);
                    s030_Test = retriveTestVector(s030, N);
                    s031_Test = retriveTestVector(s031, N);
                    s032_Test = retriveTestVector(s032, N);
                    s033_Test = retriveTestVector(s033, N);
                    s034_Test = retriveTestVector(s034, N);
                    s035_Test = retriveTestVector(s035, N);
                    s036_Test = retriveTestVector(s036, N);
                    s037_Test = retriveTestVector(s037, N);
                    s038_Test = retriveTestVector(s038, N);
                    s039_Test = retriveTestVector(s039, N);
                    s040_Test = retriveTestVector(s040, N);
                    s041_Test = retriveTestVector(s041, N);
                    s042_Test = retriveTestVector(s042, N);
                    s043_Test = retriveTestVector(s043, N);
                    s044_Test = retriveTestVector(s044, N);
                    s046_Test = retriveTestVector(s046, N);
                    s047_Test = retriveTestVector(s047, N);
                    s048_Test = retriveTestVector(s048, N);
                    s049_Test = retriveTestVector(s049, N);
                    s050_Test = retriveTestVector(s050, N);
                    s051_Test = retriveTestVector(s051, N);
                    s052_Test = retriveTestVector(s052, N);
                    s053_Test = retriveTestVector(s053, N);
                    s054_Test = retriveTestVector(s054, N);
                    s055_Test = retriveTestVector(s055, N);
                    s056_Test = retriveTestVector(s056, N);
                    #endregion

                    FindIPRosterRate(s002_Test, s003_Test, s004_Test, s005_Test, s007_Test, s008_Test, s010_Test, s011_Test, s012_Test, s013_Test, s015_Test, s016_Test, s017_Test, s018_Test, s019_Test, s020_Test, s021_Test, s022_Test, s024_Test, s025_Test, s026_Test, s027_Test, s028_Test, s029_Test, s030_Test, s031_Test, s032_Test, s033_Test, s034_Test, s035_Test, s036_Test, s037_Test, s038_Test, s039_Test, s040_Test, s041_Test, s042_Test, s043_Test, s044_Test, s046_Test, s047_Test, s048_Test, s049_Test, s050_Test, s051_Test, s052_Test, s053_Test, s054_Test, s055_Test, s056_Test, N, mean_s057);

                    FalseRejectRate(s057_Genuine, N);
                }

                else if (enterN != "100" || enterN == "200" || enterN != "300")
                {
                    Console.WriteLine("Your Input Sample size is too large, Quit");
                    Console.ReadKey();
                }
            }
            
            #region Static double arrays that represent the genuine Score vectors
            MeanVector.setValue(s002_Genuine);
            MeanVector.setValue(s003_Genuine);
            MeanVector.setValue(s004_Genuine);
            MeanVector.setValue(s005_Genuine);
            MeanVector.setValue(s007_Genuine);
            MeanVector.setValue(s008_Genuine);
            MeanVector.setValue(s010_Genuine);
            MeanVector.setValue(s011_Genuine);
            MeanVector.setValue(s012_Genuine);
            MeanVector.setValue(s013_Genuine);
            MeanVector.setValue(s015_Genuine);
            MeanVector.setValue(s016_Genuine);
            MeanVector.setValue(s017_Genuine);
            MeanVector.setValue(s018_Genuine);
            MeanVector.setValue(s019_Genuine);
            MeanVector.setValue(s020_Genuine);
            MeanVector.setValue(s021_Genuine);
            MeanVector.setValue(s022_Genuine);
            MeanVector.setValue(s024_Genuine);
            MeanVector.setValue(s025_Genuine);
            MeanVector.setValue(s026_Genuine);
            MeanVector.setValue(s027_Genuine);
            MeanVector.setValue(s028_Genuine);
            MeanVector.setValue(s029_Genuine);
            MeanVector.setValue(s030_Genuine);
            MeanVector.setValue(s031_Genuine);
            MeanVector.setValue(s032_Genuine);
            MeanVector.setValue(s033_Genuine);
            MeanVector.setValue(s034_Genuine);
            MeanVector.setValue(s035_Genuine);
            MeanVector.setValue(s036_Genuine);
            MeanVector.setValue(s037_Genuine);
            MeanVector.setValue(s038_Genuine);
            MeanVector.setValue(s039_Genuine);
            MeanVector.setValue(s040_Genuine);
            MeanVector.setValue(s041_Genuine);
            MeanVector.setValue(s042_Genuine);
            MeanVector.setValue(s043_Genuine);
            MeanVector.setValue(s044_Genuine);
            MeanVector.setValue(s046_Genuine);
            MeanVector.setValue(s047_Genuine);
            MeanVector.setValue(s048_Genuine);
            MeanVector.setValue(s049_Genuine);
            MeanVector.setValue(s050_Genuine);
            MeanVector.setValue(s051_Genuine);
            MeanVector.setValue(s052_Genuine);
            MeanVector.setValue(s053_Genuine);
            MeanVector.setValue(s054_Genuine);
            MeanVector.setValue(s055_Genuine);
            MeanVector.setValue(s056_Genuine);
            MeanVector.setValue(s057_Genuine);
            #endregion

            #endregion

            #endregion
        }

    }

    }
}
