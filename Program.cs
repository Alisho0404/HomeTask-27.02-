using HomeTask_27._02_; 

 #region 
  var course1=new Course(); 
  course1.Id=1; 
  course1.CourseName="C#"; 
  course1.Descripttion="Most powerful course"; 
  course1.PriceofCourse=1500; 
  course1.HasDiscount=false; 
  course1.Days="every day except Sunday"; 
  course1.Duration=1; 

var course2=new Course(); 
  course2.Id=2; 
  course2.CourseName=".Net"; 
  course2.Descripttion="Course with long duration"; 
  course2.PriceofCourse=1500; 
  course2.HasDiscount=true; 
  course2.Days="every day except Sunday"; 
  course2.Duration=3;  

  var course3=new Course(); 
  course3.Id=3; 
  course3.CourseName="JS"; 
  course3.Descripttion="Course for Front-end"; 
  course3.PriceofCourse=1500; 
  course3.HasDiscount=true; 
  course3.Days="every day except Sunday"; 
  course3.Duration=1;  

  var service=new CourseService(); 
  service.CreateCourse(course1);
  service.CreateCourse(course2);
  service.CreateCourse(course3);  
  #endregion

while(true)
{
    System.Console.WriteLine("Welcome to our platform, we are glad to see you"); 
    System.Console.WriteLine();
    System.Console.WriteLine("################################################################"); 
    System.Console.WriteLine();
    System.Console.WriteLine("If you want add a new course please type <add>"); 
    System.Console.WriteLine("For updating any course please enter <update>"); 
    System.Console.WriteLine("Are you interested in all course please type <all>"); 
    System.Console.WriteLine("For getting information about any course please type course <getById>"); 
    System.Console.WriteLine("If you want delete course please enter <delete>");
    System.Console.WriteLine("If you want exit  please enter <q>");
    System.Console.WriteLine("------------------------------------------------------------------"); 
    System.Console.WriteLine(); 

    string operation=Console.ReadLine(); 
    
    switch (operation)
    {
        case "add":
            var course = new Course();

            System.Console.Write("Enter an id: ");
            int id = int.Parse(Console.ReadLine());
            course.Id = id;

            System.Console.Write("Enter course name: ");
            string name = Console.ReadLine();        
            course.CourseName = name; 

            System.Console.Write("Enter description: "); 
            string descrip=Console.ReadLine();
            course.Descripttion =descrip; 

            System.Console.Write("Enter price of course(int): "); 
            int price=int.Parse(Console.ReadLine());
            course.PriceofCourse = price; 

            System.Console.Write("Is it has discount: (enter true or false)"); 
            string discount=Console.ReadLine();
            course.HasDiscount = true; 

            System.Console.Write("Enter lessons days"); 
            string days=Console.ReadLine();
            course.Days = days; 

            System.Console.Write("Enter duration of course(int): "); 
            int duration=int.Parse(Console.ReadLine());
            course.Duration = duration;

            service.CreateCourse(course); 
            System.Console.WriteLine("Course succesfully added");
            break; 
            case "update": 
            System.Console.WriteLine("Enter id of course: ");  
            int idofcourse=int.Parse(Console.ReadLine()); 
            service.GetByID(idofcourse); 
            System.Console.WriteLine("Enter new values: "); 
            var courses=new Course(); 
            
             System.Console.Write("Enter an id: ");
             courses.Id = idofcourse;

            System.Console.Write("Enter course name: ");
            string name1 = Console.ReadLine();        
            courses.CourseName = name1; 

            System.Console.Write("Enter description: "); 
            string descrip1=Console.ReadLine();
            courses.Descripttion =descrip1; 

            System.Console.Write("Enter price of course(int): "); 
            int price1=int.Parse(Console.ReadLine());
            courses.PriceofCourse = price1; 

            System.Console.Write("Is it has discount: (enter true or false)"); 
            string discount1=Console.ReadLine();
            courses.HasDiscount = true; 

            System.Console.Write("Enter lessons days"); 
            string days1=Console.ReadLine();
            courses.Days = days1; 

            System.Console.Write("Enter duration of course(int): "); 
            int duration1=int.Parse(Console.ReadLine());
            courses.Duration = duration1;

            service.UpdateCourse(courses); 
            System.Console.WriteLine($"Course with id {idofcourse} updated");
            break; 

            case "all":   
            service.GetAll();  
            var all =  service.GetAll();
 foreach(var kursi in all) 
 {
    System.Console.WriteLine("Course ID: "+kursi.Id);
    System.Console.WriteLine("Course name: "+kursi.CourseName); 
    System.Console.WriteLine("Course description: "+kursi.Descripttion);
    System.Console.WriteLine("Course price: "+kursi.PriceofCourse); 
    System.Console.WriteLine("Course discount: "+kursi.HasDiscount); 
    System.Console.WriteLine("Course days: "+kursi.Days);
    System.Console.WriteLine("Course duration (month): "+kursi.Duration); 
    System.Console.WriteLine("============================================");
 }
            break; 

            case "getById":  
            System.Console.WriteLine("Enter id of course");
            int getId=int.Parse(Console.ReadLine());
            service.GetByID(getId); 
            break; 

            case "delete": 
            System.Console.WriteLine("Enter id of course");
            int getId1=int.Parse(Console.ReadLine());
            service.DeleteCourse(getId1);
            break;

        case "q":
            return;
        default:
            Console.WriteLine("Inout Error");
            break;

    }

}
   


