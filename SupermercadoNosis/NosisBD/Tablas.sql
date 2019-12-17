use master;
create database SupermercadoNosis;
use SupermercadoNosis;

create table Caja(
	IdCaja int identity primary key,
	Estado bit not null,
);

create table Cliente(
	IdCliente int identity primary key,
	Nombre varchar(100) not null,
	Estado bit not null,
);

create table CajaXCliente (
	IdCaja int foreign key references Caja(IdCaja),
	IdCliente int foreign key references Cliente(IdCliente),
	Estado bit not null,
);

