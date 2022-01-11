using Domain;
using System;
using Xunit;

namespace TestProject
{
    public class Test1
    {
        [Fact]
        public void ValidateAdm_StoreLogic_Test()
        {
           
                // Arrange
                StoreLogic storeLogic = new StoreLogic();


                // Act
                bool result = storeLogic.ValidateAdm("123");



                // Assert
                Assert.True(result);
            
        }
    }
}
