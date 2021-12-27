using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Xunit;
using Models;

namespace Testing
{
    public class ValidateAdmTest
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
