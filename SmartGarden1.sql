drop database SmartGarden
create database SmartGarden 
use SmartGarden 

create table Tipo(
	TipoID int primary key not null identity(1,1),
	Nombre varchar(50),
	Informaciones varchar(200)
)

create table Cargo(
	CargoID int primary key not null identity(1,1),
	Cargo varchar(50),
	Descripcion varchar(100),
	Beneficios varchar(100)
)

create table Empleado(
	EmpID int primary key not null identity(1,1),
	CargoID int constraint FK_CargoID foreign key (CargoID) references Cargo(CargoID),
	Fecha_de_Contrato date, 
	Salario money, 
	Cargo varchar(30),
	Cedula varchar(11),
	Correo varchar(50), 
	Telefono varchar(10), 
	FechaNac date, 
 	Nombre varchar(25), 
	Apellido varchar(25), 
	Genero varchar(25)
)

create table Suministro(
	SumID int primary key not null identity(1,1),
	TipoID int constraint FK_TipoID foreign key (TipoID) references Tipo(TipoID),
	EmpID int constraint FK_EmpID foreign key (EmpID) references Empleado(EmpID),
	Presupuesto money, 
	Fecha_de_Salida date,
	Cantidad int
)

create table Unidad(
	UnidadID int primary key not null identity(1,1),
	TipoID int constraint FK_TipoID_Unidad foreign key (TipoID) references Tipo(TipoID),
	FeExpirado date, 
	Condicion varchar(100), 
	Precio_Unidad money
)

create table ArregloFloral(
	ArregloID int primary key not null identity(1,1),
	Descripcion varchar(200), 
	Precio_de_Complejidad money
)

create table Cliente(
	ClienteID int primary key not null identity(1,1),
	Nombre varchar(25), 
	Correo varchar(50), 
	Telefono varchar(10) 
)

create table ArregloFloral_Cliente(
	Arreglo_clienteID int primary key not null identity(1,1),
	EmpID int constraint FK_EmpID_AC foreign key (EmpID) references Empleado(EmpID),
	ClienteID int constraint FK_ClienteID foreign key (ClienteID) references Cliente(ClienteID),
	ArregloID int constraint FK_ArregloID_C foreign key (ArregloID) references ArregloFloral(ArregloID),
	Fecha_Inicial date, 
	DeadLine date, 
	Cantidad int
)

create table Paisajismo(
	PaisaID int primary key not null identity(1,1),
	ClienteID int constraint FK_ClienteID_P foreign key (ClienteID) references Cliente(ClienteID),
	Descripcion varchar(200), 
	Precio_Cliente int, 
	Presupuesto money, 
	Fecha_Inicial date, 
	DeadLine date
)

create table Paisajismo_Empleado(
	PaisaID int primary key not null identity(1,1),
	EmpID int constraint FK_EmpID_PE foreign key (EmpID) references Empleado(EmpID),
	Localizacion varchar(100)
)

create table Tarea(
	TareaID int primary key not null identity(1,1),
	Descripcion varchar(200)
)

create table Tarea_Empleado(
	Tarea_empID int primary key not null identity(1,1),
	EmpID int constraint FK_EmpID_TE foreign key (EmpID) references Empleado(EmpID),
	TareaID int constraint FK_TareaID_TE foreign key (TareaID) references Tarea(TareaID),
	Horario time, 
	Localizacion varchar(200)	
)

create table Usuario(
    UsuarioID int not null identity(1,1),
    usuario varchar(20),
    contrase varchar(20)
)

insert into Usuario 
values('Nicolas', 'lasrisas')


select * from ArregloFloral 

go
CREATE PROCEDURE INSCargo 
(@cargo varchar(50), @descripcion varchar (50), @beneficios varchar(50))
as
begin
	Insert into Cargo(Cargo, descripcion, beneficios)
	values (@cargo, @descripcion, @beneficios)
end


exec INSCargo 'Angel_leandro', 'pnga', 'la maxima'