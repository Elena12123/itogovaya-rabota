
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

примеры

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

**Описание решения**

1. задаются два массива с данными одинаковой размерности и count (счетчик) = 0,
2. задается цикл для перебора всех данных строк в массиве (i < array.Length),
3. внутри цикла задается еще один цикл для проверку строк на соответствие условий (<=3). 
- если строка соответсвует условию, она записывается во сторой массив array2[count] = array[i],
- если строка не соответствует условию, то возвращаемся к основному циклу и увеличиваем i  на +1 и т.д.

