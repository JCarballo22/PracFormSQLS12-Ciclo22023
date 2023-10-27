create database BDEmpresa;
Use BDEmpresa;

Create Table Sexo(
	IdSexo Int Not Null Primary Key Identity(1,1),
	Genero Char(1)
);

Insert Into Sexo Values('M');
Insert Into Sexo Values('F');

Select * From Sexo;

Create Table Cargo(
	IdCargo Int Not Null Primary Key Identity(1,1),
	Nombre Varchar(15) Not Null
);

Insert Into Cargo Values('Gerente');
Insert Into Cargo Values('Supervisor');
Insert Into Cargo Values('Vendedor');
Insert Into Cargo Values('Bodeguero');
Insert Into Cargo Values('Operador');

Select * From Cargo;

--Drop Table Empleado;

Create Table Empleado(
IdCodigo Int Primary Key Identity(1,1),
Nombre Varchar(30) Not Null,
Apellido Varchar(25) Not Null,
Sexo Int Not Null Foreign Key References Sexo(IdSexo), 
Cargo Int Not Null Foreign Key References Cargo(IdCargo), 
Estado Bit default(1),
Creado Datetime default(getdate())
);

Insert Into Empleado(Nombre,Apellido,Sexo,Cargo) 
values('Mario','Mendoza',1,3);

select * from Empleado;

Select E.IdCodigo, E.Nombre, E.Apellido,  S.Genero, C.Nombre
From Empleado E
Join Sexo S On S.IdSexo = E.Sexo
Join Cargo C On C.IdCargo = E.Cargo Where IdCodigo = 5;

Exec sp_rename 'Cargo.Nombre', 'Cargo','Column'



