# FigureAreaCalculatorTask

## Задание 1
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

## Задание 2
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

### Предположим что база имеет следующую структуру:

Products

id_product  | product_name | id_category

Categories

id_category | category_name

### В таком случае запрос будет выглядеть так:

SELECT Products.product_name, Categories.category_name

FROM Products 

LEFT JOIN Categories 

ON Products.id_category = Categories.id_category 
