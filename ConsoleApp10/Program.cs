using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Reflection;

namespace ConsoleApp10
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
           
            /*
            Person person = new Person("quique", "rivas",d, null, null, null, null);
            Address address = new Address("street",2,"comuna","ciudad",person,3,4,5,true,false);
            Car car = new Car("brand", "model", 2, person, "license", 2, true);
            Type tipoAdress = address.GetType();

            Type tipoCar = car.GetType();

            Type tipoPerson = person.GetType();

            Console.WriteLine("=========================================");
            PropertyInfo[] propertiesAdress = tipoAdress.GetProperties();
            MethodInfo[] methodsAdress = tipoAdress.GetMethods();
            Console.WriteLine(tipoAdress.Name);
            foreach(PropertyInfo property in propertiesAdress)
            {
                Console.WriteLine(property.Name);
            }
            foreach(MethodInfo method in methodsAdress)
            {
                Console.WriteLine(method.Name);
            }
            Console.ReadKey();

            Console.WriteLine("Car");
            Console.WriteLine("=========================================");
            PropertyInfo[] propertiesCar = tipoCar.GetProperties();
            MethodInfo[] methodsCar = tipoAdress.GetMethods();
            Console.WriteLine(tipoAdress.Name);
            foreach (PropertyInfo property in propertiesCar)
            {
                Console.WriteLine(property.Name);
            }
            foreach (MethodInfo method in methodsCar)
            {
                Console.WriteLine(method.Name);
            }
            Console.ReadKey();

            Console.WriteLine("Person");
            Console.WriteLine("=========================================");
            PropertyInfo[] propertiesPerson = tipoPerson.GetProperties();
            MethodInfo[] methodsPerson = tipoPerson.GetMethods();
            Console.WriteLine(tipoAdress.Name);
            foreach (PropertyInfo property in propertiesPerson)
            {
                Console.WriteLine(property.Name);
            }
            foreach (MethodInfo method in methodsPerson)
            {
                Console.WriteLine(method.Name);
            }
            Console.ReadKey();
            */

            List<Car> cars = new List<Car>();
            while(true){

                Address address1 = new Address(null, 0, null, null, null, 0, 0, 0, false,false);
                Console.WriteLine("Bienvenido al Registro civil");
                Console.WriteLine("Ingrese su nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su appelido:");
                string apellido = Console.ReadLine();
                Console.WriteLine("ingrese su feecha de nacimiento:");
                DateTime fechaNacimiento = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
                Address a = null;
                Console.WriteLine("ingrese su rut:");
                string rut =(Console.ReadLine());
                Console.WriteLine("ingrgese donde estudio");
                string AlmaMater = Console.ReadLine();
                Person p1 = null;
                Person p2 = null;
                Person personIngresada=new Person(nombre,apellido,fechaNacimiento,a,rut,p1,p2);
                Console.WriteLine("=========================================");

                Console.WriteLine("ingrese 1 si tiene vivienda:");
                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("ahora tomare sus datos para ingresar su vivienda:");
                    Console.WriteLine("ingrese la calle en donde vive:");
                    string calle = Console.ReadLine();
                    Console.WriteLine("ingrese el numero de su casa:");
                    int numCasa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese la comuna donde vive:");
                    string comuna = Console.ReadLine();
                    Console.WriteLine("ingrese la ciudad:");
                    string ciudad = Console.ReadLine();
                    Console.WriteLine("ingrese el ano de construcion:");
                    int anoConstruct = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese la cantidad de piezas:");
                    int cantPiezas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese la cantidad de banos:");
                    int cantBanos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("tiene patio, ingrese 0 si es que no y 1 si es que si:");
                    string op = Console.ReadLine();
                    bool tienePatio = false;
                    if(op=="1")
                    {
                        tienePatio = true;
                    }
                    else
                    {
                        tienePatio = false;
                    }
                    Console.WriteLine("tiene picina, ingrese 0 si es que no y 1 si es que si:");
                    op = Console.ReadLine();
                    bool tienePicina = false;
                    if (op == "1")
                    {
                        tienePicina = true;
                    }
                    else
                    {
                        tienePicina = false;
                    }
                    address1 = new Address(calle, numCasa, comuna, ciudad,personIngresada, anoConstruct, cantPiezas, cantBanos, tienePatio, tienePicina);
                    Console.WriteLine("=========================================");
                }
                Console.WriteLine("ingrese 1 si tiene auto:");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("ahora se inscribira su auto");
                    Console.WriteLine("ingrese la marca del auto:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("ingrese el modelo del auto:");
                    string modelo = Console.ReadLine();
                    Console.WriteLine("ingrese ano:");
                    int anoAuto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese placa de licencia:");
                    string placaLicencia = Console.ReadLine();
                    Console.WriteLine("ingrese la cantidad de cinturones:");
                    int cantCinturones = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("es diesel, escriva 0 para no y 1 para si:");
                    string op = Console.ReadLine();
                    bool esDiesel = false;
                    if (op == "1")
                    {
                        esDiesel = true;
                    }
                    else
                    {
                        esDiesel = false;
                    }
                    Car car1 = new Car(marca, modelo, anoAuto, personIngresada, placaLicencia, cantCinturones, esDiesel);
                    cars.Add(car1);
                    Console.WriteLine("=========================================");
                }
                while(true)
                {
                
                    Console.WriteLine("ingrese 1 si quiere cambiar su primer nombre, ingrese 2 si quiere cambiar su apellido, ingrese 3 si se quiere abandonarse, ingrese 4 para ser adoptado, ingrese 5 para regalar tus cosas a otra persona, ingrese 6 para ingresar una educacion, ingrese 7 para ingresar auto, ingrese 9 para meterse a las opciones de su vivienda, ingrese 10 para meterse a las opciones de su auto:,ingrese 11 para salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if(opcion==11)
                    {
                        break;
                    }
                    if (opcion == 1)
                    {
                        Console.WriteLine("ingrese el nombre a que quiere cambiar");
                        string nuevoNombre = Console.ReadLine();
                        personIngresada.changeFirstName(nuevoNombre);
                    }
                    if (opcion == 2)
                    {
                        Console.WriteLine("ingrese el apellido a que quiere cambiar");
                        string nuevoApellido = Console.ReadLine();
                        personIngresada.changeLastName(nuevoApellido);
                    }
                    if (opcion == 3)
                    {
                        personIngresada.getAbandoned();
                    }
                    if (opcion == 4)
                    {
                        Console.WriteLine("ingrese los datos de la persona que lo adopta");
                        Console.WriteLine("Ingrese su nombre:");
                        string nombre2 = Console.ReadLine();
                        Console.WriteLine("Ingrese su appelido:");
                        string apellido2 = Console.ReadLine();
                        Console.WriteLine("ingrese su feecha de nacimiento:");
                        DateTime fechaNacimiento2 = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd",
                                           System.Globalization.CultureInfo.InvariantCulture);
                        Address a2 = null;
                        Console.WriteLine("ingrese su rut:");
                        string rut2 = (Console.ReadLine());
                        Console.WriteLine("ingrgese donde estudio");
                        string AlmaMater2 = Console.ReadLine();
                        Person p12 = null;
                        Person p22 = null;
                        Person personIngresada2 = new Person(nombre, apellido, fechaNacimiento, a, rut, p1, p2);
                        personIngresada.getAdopted(personIngresada2);
                    }
                    if (opcion == 5)
                    {
                        Console.WriteLine("ingrese los datos de la persona a que quiere regalar sus cosas");
                        Console.WriteLine("Ingrese su nombre:");
                        string nombre2 = Console.ReadLine();
                        Console.WriteLine("Ingrese su appelido:");
                        string apellido2 = Console.ReadLine();
                        Console.WriteLine("ingrese su feecha de nacimiento:");
                        DateTime fechaNacimiento2 = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd",
                                           System.Globalization.CultureInfo.InvariantCulture);
                        Address a2 = null;
                        Console.WriteLine("ingrese su rut:");
                        string rut2 = (Console.ReadLine());
                        Console.WriteLine("ingrgese donde estudio");
                        string AlmaMater2 = Console.ReadLine();
                        Person p12 = null;
                        Person p22 = null;
                        Person personIngresada2 = new Person(nombre, apellido, fechaNacimiento, a, rut, p1, p2);
                        personIngresada.giveUpOwnershipToThirdParty(personIngresada2);
                    }
                    if (opcion == 6)
                    {
                        Console.WriteLine("ingrese su titulo");
                        string titulo = Console.ReadLine();
                        personIngresada.setEducation(personIngresada.Alma_mater, titulo);
                    }
                    if (opcion == 7)
                    {
                        Console.WriteLine("ahora se inscribira su auto");
                        Console.WriteLine("ingrese la marca del auto:");
                        string marca = Console.ReadLine();
                        Console.WriteLine("ingrese el modelo del auto:");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("ingrese ano:");
                        int anoAuto = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingrese placa de licencia:");
                        string placaLicencia = Console.ReadLine();
                        Console.WriteLine("ingrese la cantidad de cinturones:");
                        int cantCinturones = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("es diesel, escriva 0 para no y 1 para si:");
                        string op = Console.ReadLine();
                        bool esDiesel = false;
                        if (op == "1")
                        {
                            esDiesel = true;
                        }
                        else
                        {
                            esDiesel = false;
                        }
                        Car car1 = new Car(marca, modelo, anoAuto, personIngresada, placaLicencia, cantCinturones, esDiesel);
                        cars.Add(car1);
                        Console.WriteLine("=========================================");
                    }
                
                    if (opcion == 9)
                    {
                        int cantBanos2 = 0;
                        Console.WriteLine("ingrese 1 para agregar banos, ingrese 2 para agregar piezas, ingrese 3 para regalar tu casa a otro:");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion == 1)
                        {
                            Console.WriteLine("ingrese la cantidad de banos:");
                            cantBanos2 = Convert.ToInt32(Console.ReadLine());
                            address1.addBathrooms(cantBanos2);

                        }
                        if (opcion == 2)
                        {
                            Console.WriteLine("ingrese la cantidad de piezas:");
                            cantBanos2 = Convert.ToInt32(Console.ReadLine());
                            address1.addBeedrooms(cantBanos2);
                        }
                        if (opcion == 3)
                        {
                            Console.WriteLine("ingrese los datos de la persona a que quiere regalar sus cosas");
                            Console.WriteLine("Ingrese su nombre:");
                            string nombre2 = Console.ReadLine();
                            Console.WriteLine("Ingrese su appelido:");
                            string apellido2 = Console.ReadLine();
                            Console.WriteLine("ingrese su feecha de nacimiento:");
                            DateTime fechaNacimiento2 = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd",
                                           System.Globalization.CultureInfo.InvariantCulture); 
                            Address a2 = null;
                            Console.WriteLine("ingrese su rut:");
                            string rut2 = (Console.ReadLine());
                            Console.WriteLine("ingrgese donde estudio");
                            string AlmaMater2 = Console.ReadLine();
                            Person p12 = null;
                            Person p22 = null;
                            Person personIngresada2 = new Person(nombre, apellido, fechaNacimiento, a, rut, p1, p2);
                            address1.changeOwner(personIngresada2);
                        }
                    }
                    if (opcion == 10)
                    {
                        int contador = 0;
                        foreach(Car c in cars)
                        {
                        
                            Console.WriteLine("{0}) {1}",contador, c.Model);
                            contador++;
                        }
                        Console.WriteLine("escriba 1 para regalar el auto a otra persona, ");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion == 1)
                        {
                            Console.WriteLine("ingrese el indice del auto que quiere usar:");
                            int indice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese los datos de la persona a que quiere regalar sus cosas");
                            Console.WriteLine("Ingrese su nombre:");
                            string nombre2 = Console.ReadLine();
                            Console.WriteLine("Ingrese su appelido:");
                            string apellido2 = Console.ReadLine();
                            Console.WriteLine("ingrese su feecha de nacimiento:");
                            DateTime fechaNacimiento2 = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd",
                                           System.Globalization.CultureInfo.InvariantCulture);
                            Address a2 = null;
                            Console.WriteLine("ingrese su rut:");
                            string rut2 = (Console.ReadLine());
                            Console.WriteLine("ingrgese donde estudio");
                            string AlmaMater2 = Console.ReadLine();
                            Person p12 = null;
                            Person p22 = null;
                            Person personIngresada2 = new Person(nombre, apellido, fechaNacimiento, a, rut, p1, p2);
                            cars[indice].giveUpOwnershipToThirdParty(personIngresada2);
                        }
                    }


                }

                
               
            }
        }
    }
}
