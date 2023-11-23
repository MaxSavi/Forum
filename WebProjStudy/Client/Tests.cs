
//using System;
//using System.IO;
//using Xunit;
//using Allure.Xunit;

//namespace WebProjStudy.Client
//{
//    public class EditorTests
//    {
//        [AllureXunit]
//        public void TestRandomTextGeneration()
//        {
    
//            var editor = new Editor();

           
//            editor.GenerateRandomText();

          
//            Assert.NotEmpty(editor.TextContent);
//        }

//        [AllureXunit]
//        public void TestSaveToFile()
//        {
          
//            var editor = new Editor();
//            editor.GenerateRandomText();

            
//            editor.SaveToFile().Wait();

//            Assert.True(File.Exists("textFile.txt"));
//        }

//        [AllureXunit]
//        public void TestLoadFromFile()
//        {
            
//            var editor = new Editor();
//            File.WriteAllText("textFile.txt", "Test content");

//            editor.LoadFromFile().Wait();

         
//            Assert.Equal("Test content", editor.TextContent);
//        }

//        [AllureXunit]
//        public void TestDeleteFile()
//        {
            
//            var editor = new Editor();
//            File.WriteAllText("textFile.txt", "Test content");

           
//            editor.DeleteFile();

          
//            Assert.False(File.Exists("textFile.txt"));
//        }
//    }
//}
