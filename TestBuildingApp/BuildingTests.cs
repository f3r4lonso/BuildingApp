
using NUnit.Framework;
using Xunit.Sdk;

namespace TestBuildingApp
{

    public class BuildingTests
    {
        [Fact]
        public void TestSetUpDailyWork()
        {
            // Arrange
            var workers = Repository.Service.LoadData.LoadDataFromJson();
            var building = new Building(workers);
            var expectedOutput = "buen dia gente\r\n" +
                "Maria Florencia Empezo la tarea: Sacando Fotocopias En El piso: 5\r\n" +
                "Pablo Dias Empezo la tarea: Sacando Fotocopias En El piso: 3\r\n" +
                "Carla Tello Empezo la tarea: Sacando Fotocopias En El piso: 3\r\n" +
                "Pablo Dias Termino la tarea: Sacando Fotocopias En El piso: 3 Le tomó: 1 horas.\r\n" +
                "Maria Florencia Termino la tarea: Sacando Fotocopias En El piso: 5 Le tomó: 3 horas.\r\n" +
                "Carla Tello Termino la tarea: Sacando Fotocopias En El piso: 3 Le tomó: 6 horas.\r\n" +
                "Maria Florencia Empezo la tarea: Estudiando Casos En El piso: 4\r\n" +
                "Pablo Dias Empezo la tarea: Reunion General En El piso: 5\r\n" +
                "Carla Tello Empezo la tarea: Reunion con RRHH En El piso: 6\r\n" +
                "Maria Florencia Termino la tarea: Estudiando Casos En El piso: 4 Le tomó: 3 horas.\r\n" +
                "Pablo Dias Termino la tarea: Reunion General En El piso: 5 Le tomó: 7 horas.\r\n" +
                "Carla Tello Termino la tarea: Reunion con RRHH En El piso: 6 Le tomó: 2 horas.\r\n" +
                "Hasta mañana\r\n";

            // Act
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                building.SetUpDailyWork();
                var output = writer.ToString().Replace("\r\n", "\n").Replace("\n", "\r\n");

                // Assert
                Assert.AreSame(expectedOutput, output);
            }
        }
    }
}
