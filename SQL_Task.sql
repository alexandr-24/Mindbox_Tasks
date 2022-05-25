CREATE TABLE Категория
(
	Код_категории INT PRIMARY KEY IDENTITY(1,1),
	Название_категории NVARCHAR(100) NOT NULL
)

CREATE TABLE Продукт
(
	Код_продукта INT PRIMARY KEY IDENTITY(1,1),
	Название_продукта NVARCHAR(100) NOT NULL
)

CREATE TABLE Соответствие
(
	Код_продукта INT FOREIGN KEY REFERENCES Продукт(Код_продукта),
	Код_категории INT FOREIGN KEY REFERENCES Категория(Код_категории),
	PRIMARY KEY (Код_продукта, Код_категории)
)

INSERT INTO Категория VALUES ('Сладкое'), ('Мороженое'), ('Шоколадки')
INSERT INTO Продукт VALUES ('Шоколадка Milka'), ('Мороженое пломбир'), ('Киндер'), ('Горкий шоколад'), ('Скитлс')
INSERT INTO Соответствие VALUES (1, 1), (1, 3), (2, 1), (2, 2), (3, 1), (4, 3)

SELECT T1.Название_продукта, T3.Название_категории
FROM Продукт T1
LEFT JOIN Соответствие T2 ON T1.Код_продукта = T2. Код_продукта
LEFT JOIN Категория T3 ON T2.Код_категории = T3.Код_категории