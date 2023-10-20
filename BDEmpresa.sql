create database BDEmpresa;
Use BDEmpresa;

Create Table Empleado(
IdCodigo Int Primary Key Identity(1,1),
Nombre Varchar(30) Not Null,
Apellido Varchar(25) Not Null,
sexo Char(1) Not Null,
Cargo Varchar(15) Not Null,
Estado Bit default(1),
Creado Datetime default(getdate())
);

select * from Empleado;

Insert Into Empleado(Nombre,Apellido,sexo,Cargo) 
values('','Mendoza','M','Vendedor');