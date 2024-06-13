using WalkthroughWritingLinqQueries;

// Create a data source by using a collection initializer.
IEnumerable<Student> students = [
    new Student(First: "Claire",   Last: "O'Donnell",  ID: 112, Scores: [75, 84, 91, 39]),
    new Student(First: "Sven",     Last: "Mortensen",  ID: 113, Scores: [88, 94, 65, 91]),
    new Student(First: "Cesar",    Last: "Garcia",     ID: 114, Scores: [97, 89, 85, 82]),
    new Student(First: "Debra",    Last: "Garcia",     ID: 115, Scores: [35, 72, 91, 70]),
    new Student(First: "Fadi",     Last: "Fakhouri",   ID: 116, Scores: [99, 86, 90, 94]),
    new Student(First: "Hanying",  Last: "Feng",       ID: 117, Scores: [93, 92, 80, 87]),
    new Student(First: "Hugo",     Last: "Garcia",     ID: 118, Scores: [92, 90, 83, 78]),

    new Student("Lance",   "Tucker",      119, [68, 79, 88, 92]),
    new Student("Terry",   "Adams",       120, [99, 82, 81, 79]),
    new Student("Eugene",  "Zabokritski", 121, [96, 85, 91, 60]),
    new Student("Michael", "Tucker",      122, [94, 92, 91, 91])
];


//1. Query to  produces a list of all students whose score on the first test was greater than 90.


IEnumerable<Student> studentQuery1 = from student in students
                                     where student.Scores[0] > 90
                                     select student;

Console.WriteLine("Query to  produces a list of all students whose score on the first test was greater than 90: ");
foreach (Student student in studentQuery1)
{
    Console.WriteLine($"{student.First} {student.Last}");
}
Console.WriteLine();
//Order the query results

//orders the results in alphabetical order from A to Z according to the family name of each student.

IEnumerable<Student> studentQuery2 = from student in students
                                     orderby student.Last
                                     where student.Scores[0] > 90
                                     select student;
Console.WriteLine("orders the results in alphabetical order from A to Z according to the family name of each student:");

foreach (Student student in studentQuery2)
{
    Console.WriteLine($"{student.First} {student.Last}");
}
Console.WriteLine();

// orders the results in reverse order according to the score on the first test, from the highest score to the lowest score.

IEnumerable<Student> studentQuery3 = from student in students
                                     orderby student.Scores[0] descending
                                     where student.Scores[0] > 90
                                     select student;


Console.WriteLine("Print the results in reverse order according to the score on the first test, from the highest score to the lowest score:");
foreach (Student student in studentQuery3)
{
    Console.WriteLine($"{student.First} {student.Last}  => score in first test : {student.Scores[0]}");
}
Console.WriteLine();

// Group the query
//groups the students by using the first letter of their family name as the key.

IEnumerable<IGrouping<char, Student>> studentGroupingQuery = from student in students 
                                                       group student by student.Last[0];

Console.WriteLine("groups the students by using the first letter of their family name as the key:");
foreach (IGrouping<char, Student> studentQuery in studentGroupingQuery)
{
    Console.WriteLine($"Keys used for Grouping the students :{studentQuery.Key}");
    foreach (Student student in studentQuery)
    {
        Console.WriteLine($"{student.First} {student.Last}");
    }
}
Console.WriteLine();
// Order the groups by their key value
IEnumerable<IGrouping<char, Student>> studentOrderbyGroupingQuery = from student in students
                                                                    group student by student.Last[0] into studentGroup
                                                                    orderby studentGroup.Key
                                                                    select studentGroup;

Console.WriteLine("group the students by using the first letter of their family name as the key. Key should follow alphabetical order: ");

foreach (IGrouping<char, Student> studentQuery in studentOrderbyGroupingQuery)
{
    Console.WriteLine($"Keys used for Grouping the students :{studentQuery.Key}");
    foreach (Student student in studentQuery)
    {
        Console.WriteLine($"{student.First} {student.Last}");
    }
}
Console.WriteLine();