Course programmering = new Course("Programmering", 2);

Course matematik = new Course("Matematik", 3);

Student hamzeh = new Student("Hamzeh");

Student yasmin = new Student("Yasmin");

Student adam = new Student("Adam");

hamzeh.Join(programmering);

yasmin.Join(programmering);

adam.Join(matematik);

Console.WriteLine(programmering);
programmering.RollCall();

Console.WriteLine();

Console.WriteLine(hamzeh);
hamzeh.Schedule();

Console.WriteLine("\nEfter att Hamzeh lämnar:");

hamzeh.Leave(programmering);

Console.WriteLine(programmering);
programmering.RollCall();

Console.WriteLine("\nHamzehs kurser:");
hamzeh.Schedule();

adam.Leave(programmering);

matematik.Enroll(yasmin);
Console.WriteLine("\nYasmins kurser:");
yasmin.Schedule();