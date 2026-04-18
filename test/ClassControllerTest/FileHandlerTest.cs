using ClassController;

namespace ClassControllerTest
{
    /// <summary>
    /// tests for the <see cref="ClassController.FileHandler{T}"/> class.
    /// </summary>
    [TestClass]
    public class FileHandlerTest
    {
        /// <summary>
        /// Loads the data should throw argument exception when file name is null or empty.
        /// </summary>
        [TestMethod]
        public void LoadData_ShouldThrowArgumentException_WhenFileNameIsNullOrEmpty()
        {
            // Arrange
            var fileHandler = new FileHandler<object>();
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => fileHandler.LoadData(null!));
            Assert.ThrowsException<ArgumentException>(() => fileHandler.LoadData(string.Empty));
        }
        /// <summary>
        /// Loads the data should throw file not found exception when file does not exist.
        /// </summary>
        [TestMethod]
        public void LoadData_ShouldThrowFileNotFoundException_WhenFileDoesNotExist()
        {
            // Arrange
            var fileHandler = new FileHandler<object>();
            var nonExistentFileName = "nonexistentfile.csv";
            // Act & Assert
            Assert.ThrowsException<FileNotFoundException>(() => fileHandler.LoadData(nonExistentFileName));


        }
    }
}
