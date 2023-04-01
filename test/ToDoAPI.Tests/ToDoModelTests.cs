using ToDoAPI.Models;

namespace ToDoAPI.Tests;

public class ToDoModelTests
{
    [Fact]
    public void CanChangeName()
    {
        //Arrange
        var testToDo = new ToDoItem
        {
            Name = "Complete Unit Tests"
        };

        //Act
        testToDo.Name = "Error error";

        //Assert
        Assert.Equal("Error Pipeline", testToDo.Name);
    }
}