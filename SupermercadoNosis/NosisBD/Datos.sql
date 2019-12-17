use SupermercadoNosis;

insert into Caja (Estado) values (1),
								 (1),
								 (1),
								 (1),
								 (1),
								 (1);

insert into Cliente (Nombre,Estado) values	('Victoria',1),
											('Gabriel',1),
											('Damian',1),
											('Pedro',1),
											('Mariana',1),
											('Daniela',1),
											('Martin',1);

insert into CajaXCliente(IdCaja,IdCliente,Estado) values(1,1,1),
														(2,2,1),
														(3,3,1),
														(4,4,1),
														(5,5,1),
														(1,6,1),
														(6,7,1);


