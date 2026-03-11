using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

(string name, int age, int grade) st1 = CreateStudent("철수", 16, 1);
(string name, int age, int grade) st2 = CreateStudent("영희", 17, 2);
(string name, int age, int grade) st3 = CreateStudent("민수", 18, 3);

Console.WriteLine("=== 학생 정보 출력 ===");
PrintStudent(st1);
PrintStudent(st2);
PrintStudent(st3);
Console.WriteLine();

Console.WriteLine("=== 첫 번째 학생 분해 ===");
(string name, int age, int grade) = st1;
Console.WriteLine($"이름: {name}");
Console.WriteLine($"나이: {age}");
Console.WriteLine($"학년: {grade}");

(string name, int age, int grade) CreateStudent(string name, int age, int grade)
{
    var student = (name,  age, grade);
    return student;
}

void PrintStudent((string name, int age, int grade) student) => Console.WriteLine($"{student.name} - 나이: {student.age}세, 학년: {student.grade}학년");