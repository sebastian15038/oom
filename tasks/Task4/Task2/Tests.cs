using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]

    class Tests
    {
        [Test]
        public void TestBirthday()
        {

            Lehrer d = new Lehrer("Mathe",25,3);
            d.Geburtstag();
            Assert.IsTrue(d.alter==26);

            }

        [Test]
        public void TestFach()
        {
            Lehrer d = new Lehrer("Mathe", 25, 3);
            Assert.IsTrue(d.fach == "Mathe");
        }
        [Test]
        public void TestBerufserfahrung()
        {
            Lehrer d = new Lehrer("Mathe", 25, 3);
            Assert.IsTrue(d.berufserfahren== true);

        }
        [Test]
        public void CannotCreateTeacherWithoutSubject()
        {
            Assert.Catch(() => {
                Lehrer d = new Lehrer("",10,15);
            });
        }
        [Test]
        public void DozentBirthday()
        {
            Dozent z = new Dozent("Sebi","Kielbasa","Mathematik",10);
            z.Geburtstag();
            Assert.IsTrue(z.alter == 11);
        }

        [Test]
        public void SetBerufserfahrenAfterCreatingTeacher()
        {
            Lehrer d = new Lehrer("Mathe", 25, 0);
            Assert.IsTrue(d.berufserfahren == false);
        }

        [Test]
        public void ChackValuesAfterCreatingDozent()
        {
            Dozent d = new Task2.Dozent("Sebi", "Kielbasa", "Informatik", 15);
            Assert.IsTrue(d.name == "Sebi");
            Assert.IsTrue(d.nname == "Kielbasa");
            Assert.IsTrue(d.freifach == "Informatik");
            Assert.IsTrue(d.alter == 15);
        }

        [Test]
        public void ChackValuesAfterCreatingTeacher()
        {
            Lehrer d = new Lehrer("Mathe", 25, 1);
            Assert.IsTrue(d.fach == "Mathe");
            Assert.IsTrue(d.alter == 25);
            Assert.IsTrue(d.Berufserfahrung== 1);
            Assert.IsTrue(d.berufserfahren == true);
        }


    }

}

