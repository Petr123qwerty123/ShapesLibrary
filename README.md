# ShapesLibrary

[![CI](https://github.com/Petr123qwerty123/ShapesLibrary/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Petr123qwerty123/ShapesLibrary/actions/workflows/dotnet.yml)

# Задача на C#

*Напишите на C# [библиотеку для поставки внешним клиентам](https://github.com/Petr123qwerty123/ShapesLibrary/blob/master/ShapesLibrary/bin/Debug/ShapesLibrary.1.0.0.nupkg), которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:*

 *- Юнит-тесты*
 
 *- Легкость добавления других фигур*
 
 *- Вычисление площади фигуры без знания типа фигуры*
 
 *- Проверку на то, является ли треугольник прямоугольным"*

# Задача на SQL

*В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.*

###  Создание таблиц:
    CREATE TABLE categories (
    category_id int  NOT NULL,
    title nvarchar(128)  NOT NULL,
    CONSTRAINT categories_pk PRIMARY KEY  (category_id)
    );
    
    CREATE TABLE product_categories (
    product_id int  NOT NULL,
    category_id int  NOT NULL,
    CONSTRAINT product_categories_pk PRIMARY KEY  (product_id,category_id)
    );
    
    CREATE TABLE products (
    product_id int  NOT NULL,
    title nvarchar(128)  NOT NULL,
    CONSTRAINT products_pk PRIMARY KEY  (product_id)
    );

    ALTER TABLE product_categories ADD CONSTRAINT product_categories_categories
    FOREIGN KEY (category_id)
    REFERENCES categories (category_id);

    ALTER TABLE product_categories ADD CONSTRAINT product_categories_products
    FOREIGN KEY (product_id)
    REFERENCES products (product_id);

###  Заполнение таблиц:
    INSERT INTO products(product_id,title) VALUES (1, 'Колбаса');
    INSERT INTO products(product_id,title) VALUES (2, 'Макароны');
    INSERT INTO products(product_id,title) VALUES (3, 'Печенье');
    
    INSERT INTO categories(category_id,title) VALUES (1, 'Колбасы');
    INSERT INTO categories(category_id,title) VALUES (2, 'Мясо');
    INSERT INTO categories(category_id,title) VALUES (3, 'Бакалея');
    INSERT INTO categories(category_id,title) VALUES (4, 'Тесто');
    
    INSERT INTO product_categories(product_id,category_id) VALUES (1, 1);
    INSERT INTO product_categories(product_id,category_id) VALUES (1, 2);
    INSERT INTO product_categories(product_id,category_id) VALUES (2, 3);
    INSERT INTO product_categories(product_id,category_id) VALUES (2, 4);

### Решение задачи:
    SELECT products.title, categories.title 
    FROM products LEFT JOIN product_categories ON products.product_id = product_categories.product_id 
    LEFT JOIN categories ON product_categories.category_id = categories.category_id;
