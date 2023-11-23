////using System;
////using System.IO;
////using Xunit;

////public class ForumEditorTests
////{
////    [Fact]
////    public void GenerateRandomText_ShouldGenerateTextWithGivenNumberOfWords()
////    {
////        // Arrange
////        var forumEditor = new ForumEditor();

////        // Act
////        forumEditor.GenerateRandomText(100);

////        // Assert
////        Assert.Equal(100, forumEditor.TextContent.Split(' ').Length);
////    }

////    [Fact]
////    public async void SaveToFile_ShouldSaveTextToFile()
////    {
////        // Arrange
////        var forumEditor = new ForumEditor();
////        forumEditor.GenerateRandomText(100);

////        // Act
////        await forumEditor.SaveToFile();

////        // Assert
////        Assert.True(File.Exists("textFile.txt"));
////    }

////    [Fact]
////    public async void LoadFromFile_ShouldLoadTextFromFile()
////    {
////        // Arrange
////        var forumEditor = new ForumEditor();
////        forumEditor.GenerateRandomText(100);
////        await forumEditor.SaveToFile();

////        // Act
////        await forumEditor.LoadFromFile();

////        // Assert
////        Assert.Equal(forumEditor.TextContent, await File.ReadAllTextAsync("textFile.txt"));
////    }

////    [Fact]
////    public void DeleteFile_ShouldDeleteFileIfExists()
////    {
////        // Arrange
////        var forumEditor = new ForumEditor();
////        forumEditor.GenerateRandomText(100);
////        forumEditor.SaveToFile().Wait();

////        // Act
////        forumEditor.DeleteFile();

////        // Assert
////        Assert.False(File.Exists("textFile.txt"));
////    }
////}

////public class ForumEditor
////{
////    public string TextContent { get; set; } = "";
////    private readonly RandomTextGenerator textGenerator = new RandomTextGenerator();

////    public void GenerateRandomText(int numberOfWords)
////    {
////        TextContent = textGenerator.GenerateRandomText(numberOfWords);
////    }

////    public async Task SaveToFile()
////    {
////        await File.WriteAllTextAsync("textFile.txt", TextContent);
////    }

////    public async Task LoadFromFile()
////    {
////        if (File.Exists("textFile.txt"))
////        {
////            TextContent = await File.ReadAllTextAsync("textFile.txt");
////        }
////        else
////        {
////            TextContent = "Файл не найден";
////        }
////    }

////    public void DeleteFile()
////    {
////        if (File.Exists("textFile.txt"))
////        {
////            File.Delete("textFile.txt");
////            TextContent = "Файл Удален";
////        }
////        else
////        {
////            TextContent = "Файл не найден";
////        }
////    }
////}

////public class RandomTextGenerator
////{
////    private static readonly string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "l", "n", "m", "o", "p", "q", "r" };

////    public string GenerateRandomText(int numberOfWords)
////    {
////        Random random = new Random();
////        string generatedText = "";

////        for (int i = 0; i < numberOfWords; i++)
////        {
////            int randomIndex = random.Next(0, letters.Length);
////            generatedText += letters[randomIndex] + " ";
////        }

////        return generatedText.Trim();
////    }
////}
//////dotnet add reference ../WebProjStudy/WebProjStudy.Client.csproj
//////dotnet test C:\Users\Asus\Desktop\VS\WebProjStudy\WebProjStudy\Client\Tests.cs

////using System;
////using System.IO;
////using Xunit;

////namespace YourNamespace.Tests
////{
////    public class EditorTests
////    {
////        [Fact]
////        public void GenerateRandomText_ResultsInNonEmptyText()
////        {
////            // Arrange
////            var editor = new Editor(); // Замените на фактический путь к вашему файлу
////            var initialTextContent = editor.textContent;

////            // Act
////            editor.GenerateRandomText();

////            // Assert
////            Assert.False(string.IsNullOrEmpty(editor.textContent));
////            Assert.NotEqual(initialTextContent, editor.textContent);
////        }

////        [Fact]
////        public async Task SaveToFile_FileContainsExpectedContent()
////        {
////            // Arrange
////            var editor = new Editor(); // Замените на фактический путь к вашему файлу
////            editor.GenerateRandomText();
////            var expectedContent = editor.textContent;

////            // Act
////            await editor.SaveToFile();

////            // Assert
////            Assert.True(File.Exists("textFile.txt"));
////            var actualContent = await File.ReadAllTextAsync("textFile.txt");
////            Assert.Equal(expectedContent, actualContent);
////        }

////        // Добавьте другие тесты по аналогии
////    }
////}
////using System;
////using System.IO;
////using Xunit;
////using WebProjStudy.Client.Pages;

////public class ForumEditorTests
////{
////    [Fact]
////    public void TestGenerateRandomText()
////    {
////        // Arrange
////        var editor = new Pages.ForumEditor();

////        // Act
////        editor.GenerateRandomText();

////        // Assert
////        Assert.False(string.IsNullOrWhiteSpace(editor.TextContent));
////    }

////    [Fact]
////    public async void TestSaveToFile()
////    {
////        // Arrange
////        var editor = new Pages.Index();

////        // Act
////        editor.GenerateRandomText();
////        await editor.SaveToFile();

////        // Assert
////        Assert.True(File.Exists("textFile.txt"));
////        Assert.False(string.IsNullOrWhiteSpace(editor.TextContent));
////    }

////    [Fact]
////    public async void TestLoadFromFile()
////    {
////        // Arrange
////        var editor = new Pages.Index();
////        var expectedText = "Текст для теста загрузки из файла";

////        // Act
////        await File.WriteAllTextAsync("textFile.txt", expectedText);
////        await editor.LoadFromFile();

////        // Assert
////        Assert.Equal(expectedText, editor.TextContent);
////    }

////    [Fact]
////    public void TestDeleteFile()
////    {
////        // Arrange
////        var editor = new Pages.Index();

////        // Act
////        editor.DeleteFile();

////        // Assert
////        Assert.Equal("Файл не найден", editor.TextContent);

////        // Create a file for deletion test
////        File.WriteAllText("textFile.txt", "Текст для теста удаления файла");

////        // Act
////        editor.DeleteFile();

////        // Assert
////        Assert.Equal("Файл Удален", editor.TextContent);
////        Assert.False(File.Exists("textFile.txt"));
////    }
////}

//using Microsoft.VisualStudio.TestTools.UnitTesting;

//[TestClass]
//public class ForumEditorTests
//{
//    [TestMethod]
//    public void GenerateRandomText_ShouldCreateNonEmptyText()
//    {
//        // Arrange
//        var forumEditor = new ForumEditor();

//        // Act
//        forumEditor.GenerateRandomText();

//        // Assert
//        Assert.IsFalse(string.IsNullOrWhiteSpace(forumEditor.TextContent));
//    }

//    [TestMethod]
//    public async Task SaveToFile_ShouldCreateFile()
//    {
//        // Arrange
//        var forumEditor = new ForumEditor();

//        // Act
//        await forumEditor.SaveToFile();

//        // Assert
//        Assert.IsTrue(File.Exists("textFile.txt"));
//    }

//    [TestMethod]
//    public async Task LoadFromFile_ShouldLoadFileContent()
//    {
//        // Arrange
//        var forumEditor = new ForumEditor();
//        forumEditor.TextContent = "Test content";

//        // Act
//        await forumEditor.SaveToFile();
//        await forumEditor.LoadFromFile();

//        // Assert
//        Assert.AreEqual("Test content", forumEditor.TextContent);
//    }

//    [TestMethod]
//    public void DeleteFile_ShouldRemoveFile()
//    {
//        // Arrange
//        var forumEditor = new ForumEditor();

//        // Act
//        forumEditor.DeleteFile();

//        // Assert
//        Assert.IsFalse(File.Exists("textFile.txt"));
//    }
//}
//using Xunit;
//using WebProjStudy.Client;

//public class ForumEditorTests
//{
//    [Fact]
//    public void TestGenerateRandomText()
//    {
//        // Arrange
//        var forumEditor = new GenerateRandomText.ForumEditor();

//        // Act
//        forumEditor.GenerateRandomText();

//        // Assert
//        Assert.False(string.IsNullOrWhiteSpace(forumEditor.TextContent), "Generated text should not be empty");
//    }

//    [Fact]
//    public void TestSaveLoadDeleteFile()
//    {
//        // Arrange
//        var forumEditor = new Pages.Index();

//        // Act
//        forumEditor.GenerateRandomText();
//        forumEditor.SaveToFile().Wait();
//        forumEditor.LoadFromFile().Wait();

//        // Assert
//        Assert.False(string.IsNullOrWhiteSpace(forumEditor.TextContent), "Loaded text should not be empty");

//        // Act
//        forumEditor.DeleteFile();

//        // Assert
//        Assert.Equal("Файл Удален", forumEditor.TextContent);
//    }
//}
//using System;
//using System.IO;
//using Xunit;

//public class ForumEditorTests
//{
//    [Fact]
//    public void GenerateRandomText_ShouldGenerateNonEmptyText()
//    {
//        // Arrange
//        var forumEditor = new ForumEditor();
//        var textGenerator = new ForumEditor.RandomTextGenerator();

//        // Act
//        string generatedText = textGenerator.GenerateRandomText(100);

//        // Assert
//        Assert.False(string.IsNullOrWhiteSpace(generatedText));
//    }

//    // Другие тесты...
//}

//using System;
//using System.IO;
//using Xunit;

//public class ForumEditorTests
//{
//    [Fact]
//    public void GenerateRandomText_ShouldGenerateNonEmptyText()
//    {
//        // Arrange
//        var textGenerator = new RandomTextGenerator();

//        // Act
//        string generatedText = textGenerator.GenerateRandomText(100);

//        // Assert
//        Assert.False(string.IsNullOrWhiteSpace(generatedText));
//    }

//    [Fact]
//    public async void SaveToFile_ShouldCreateFileWithContent()
//    {
//        // Arrange
//        var textGenerator = new RandomTextGenerator();
//        var textContent = textGenerator.GenerateRandomText(100);

//        // Act
//        await SaveToFileAsync(textContent);

//        // Assert
//        Assert.True(File.Exists("textFile.txt"));

//        string fileContent = File.ReadAllText("textFile.txt");
//        Assert.False(string.IsNullOrWhiteSpace(fileContent));
//        Assert.Equal(textContent, fileContent);
//    }

//    [Fact]
//    public async void LoadFromFile_ShouldLoadContentFromFile()
//    {
//        // Arrange
//        var textGenerator = new RandomTextGenerator();
//        var textContent = textGenerator.GenerateRandomText(100);
//        await SaveToFileAsync(textContent);

//        // Act
//        string loadedContent = await LoadFromFileAsync();

//        // Assert
//        Assert.Equal(textContent, loadedContent);
//    }

//    [Fact]
//    public void DeleteFile_ShouldDeleteFile()
//    {
//        // Arrange
//        var textGenerator = new RandomTextGenerator();
//        var textContent = textGenerator.GenerateRandomText(100);
//        SaveToFile(textContent);

//        // Act
//        DeleteFile();

//        // Assert
//        Assert.False(File.Exists("textFile.txt"));
//    }

//    // Вспомогательные методы
//    private async Task SaveToFileAsync(string textContent)
//    {
//        await File.WriteAllTextAsync("text
