using Microsoft.VisualStudio.TestPlatform.TestHost;
using Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
    [TestFixture]
    public class SchoolsTest
    {
        
        [Test]
        public void NotNullTest()
        {
            School sch=new School();
            sch.SchoolName = "Narayana";
            sch.SchoolBranch = "Hyd";
            sch.Fee = 0;
            Assert.NotNull(sch.SchoolName);
            Assert.NotNull(sch.SchoolBranch);
            Assert.NotNull(sch.Fee);
        }
       [Test]
        public void SchooolId()
        {
            School sch=new School();
            sch.Id = 1;
            int sid1 = 1,sid2=3;
            Assert.That(sid1, Is.EqualTo(sch.Id));
            
        }
    }
}
