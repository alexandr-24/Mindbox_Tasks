CREATE TABLE ���������
(
	���_��������� INT PRIMARY KEY IDENTITY(1,1),
	��������_��������� NVARCHAR(100) NOT NULL
)

CREATE TABLE �������
(
	���_�������� INT PRIMARY KEY IDENTITY(1,1),
	��������_�������� NVARCHAR(100) NOT NULL
)

CREATE TABLE ������������
(
	���_�������� INT FOREIGN KEY REFERENCES �������(���_��������),
	���_��������� INT FOREIGN KEY REFERENCES ���������(���_���������),
	PRIMARY KEY (���_��������, ���_���������)
)

INSERT INTO ��������� VALUES ('�������'), ('���������'), ('���������')
INSERT INTO ������� VALUES ('��������� Milka'), ('��������� �������'), ('������'), ('������ �������'), ('������')
INSERT INTO ������������ VALUES (1, 1), (1, 3), (2, 1), (2, 2), (3, 1), (4, 3)

SELECT T1.��������_��������, T3.��������_���������
FROM ������� T1
LEFT JOIN ������������ T2 ON T1.���_�������� = T2. ���_��������
LEFT JOIN ��������� T3 ON T2.���_��������� = T3.���_���������