# ComplexClass
Комплексные числа (структуры, перегрузка операций, приведения типов, методы object)

Разработайте класс Complex, который хранит в себе комплексное число в виде вещественной и мнимой части. Этот класс должен обладать следующей функциональностью:
•	Содержать Конструкторы комплексного числа, принимающие только вещественную часть или вещественную и мнимую части.
  Также необходимо реализовать функцию, создающую комплексное число по модулю и аргументу (например, static метод создания)
•	Иметь Свойства для получения вещественной и мнимой части (чтение и установка значения)
•	 Иметь Вычислимые свойства, возвращающие значение модуля и аргумента
•	Переопределять арифметические операции (+, - , * , / )
•	Переопределять Операции сравнения (равенство-неравенство). 
  При этом соответствующим образом должны быть переопределены методы Equals() и GetHashCode().
  •	Обладать возможностью явного преобразования в вещественное число и неявного преобразования из вещественного числа.
  Это достигается при помощи перегрузки преобразований типов.
•	Класс должен иметь возможность преобразовывать комплексное число в строку обычной записи комплексного числа. Строка, должна быть “красивая” (т.е. 1-2i,  а не 1 + -2i, или 1, а не 1+0i, или 2i, а не 0+2i, или 1+i, а не 1+1i). Должна быть возможность распечатки числа как Console.WriteLine(complex). Преобразование достигается при помощи перегрузки метода ToString().
