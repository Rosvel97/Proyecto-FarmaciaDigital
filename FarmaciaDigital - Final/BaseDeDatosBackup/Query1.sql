create database FarmaciaDigital
go
use FarmaciaDigital
go

create table Usuarios
(
NombreUsuario varchar(50) primary key,
Contrase�a varchar(50)
)
go

Insert into Usuarios (NombreUsuario, Contrase�a) values ('Chris','2203')
Insert into Usuarios (NombreUsuario, Contrase�a) values ('David','123')
Insert into Usuarios (NombreUsuario, Contrase�a) values ('admin','123')
go 

create table Pacientes
(
Expediente int primary key identity (1,1) not null,
Nombres varchar(100) not null,
Apellidos varchar(100) not null,
DUI int not null,
Telefono int not null,
Correo varchar(100) not null,
Sexo varchar (20) not null,
FechaNacimiento datetime not null,
FechaIngreso datetime default getdate() not null,
AlergiaMedicamento varchar(100) not null
)
go 

create table Medicamentos
(
ID int primary key identity (1,1),
Nombre varchar(50) not null,
Cantidad int not null,
Precio float not null,
TipoIngreso varchar(50) not null
)
go 

create procedure SP_Actualizar_Pacientes
@Expediente int, 
@Nombre varchar(30), 
@Apellido varchar(30), 
@DUI int, 
@Telefono int, 
@Correo varchar(30), 
@Sexo char(1), 
@FechaNaciemto datetime, 
@Alergia varchar(100)
as 
	update Pacientes set 
	Nombres = @Nombre,
	Apellidos = @Apellido, 
	DUI = @DUI, 
	Telefono = @Telefono, 
	Correo = @Correo,
	Sexo = @Sexo, 
	FechaNacimiento = @FechaNaciemto, 
	AlergiaMedicamento = @Alergia
	where Expediente = @Expediente
GO	

create procedure SP_Actualizar_Medicamentos
@Id int, 
@Nombre varchar(30), 
@Cantidad int, 
@Precio float, 
@TipoIngreso varchar(30)
as 
	update Medicamentos set 
	Nombre = @Nombre, 
	Cantidad = @Cantidad, 
	Precio = @Precio, 
	TipoIngreso = @TipoIngreso
	where id = @Id
go

select * from Medicamentos


---LLENAMOS LA BD CON TODOS LOS MEDICAMENTOS
insert into Medicamentos (Nombre, cantidad, precio, TipoIngreso)
values
('yodo',10,1.00,'comprado'),
('zinc',100,1.00,'comprado'),
('yoduro de tibezonio',5,2.25,'comprado'),
('yodopolivinilpirrolidona',5,10.00,'comprado'),
('lactobacillus',3,2.00,'comprado'),
('nafazolina',50,2.50,'comprado'),
('naproxeno',50,2.00,'comprado'),
('nicotina',100,1.00,'comprado'),
('nicotinamida',100,2.00,'comprado'),
('nimesulina',50,2.00,'comprado'),
('nistatina',30,2.00,'comprado'),
('nitrato de potasio',40,2.00,'comprado'),
('nonoxinol',20,1.00,'comprado'),
('noscapina',35,2.00,'comprado'),
('omeprazol',50,4.00,'comprado'),
('oxiconazol',30,5.00,'comprado'),
('oxido de zinc',10,5.00,'comprado'),
('oximetazolina',30,2.00,'comprado'),
('pancreatina',50,3.00,'comprado'),
('paracetamol',40,3.00,'comprado'),
('penciclovir',60,2.00,'comprado'),
('permetrina',70,1.00,'comprado'),
('peroxido de hidrgeno',30,2.00,'comprado'),
('peroxido de benzoilo',40,3.00,'comprado'),
('petrolato blanco',30,5.00,'comprado'),
('picosulfato de sodio',50,1.00,'comprado'),
('pidolato de calcio',80,2.50,'comprado'),
('pirantel embonato',30,2.00,'comprado'),
('lactasa',30,2.00,'comprado'),
('piridoxina',30,2.00,'comprado'),
('clorhicrato',55,2.00,'comprado'),
('piroxicam',40,2.00,'comprado'),
('polisulfato',30,2.00,'comprado'),
('polivinil',30,5.00,'comprado'),
('polivinilpirrolidona',70,2.00,'comprado'),
('poloxamer',60,2.00,'comprado'),
('pramiverina',30,1.00,'comprado'),
('pramoxina',20,2.50,'comprado'),
('psylium',30,5.00,'comprado'),
('ranitidina',100,1.00,'comprado'),
('ruibarvo polvo',30,10.00,'comprado'),
('salicilato',40,2.00,'comprado'),
('simeticona',30,2.00,'comprado'),
('sulfuro',50,2.00,'comprado'),
('lactasa',30,2.00,'comprado'),
('sulfato',30,3.00,'comprado'),
('tiamina',50,2.00,'comprado'),
('terbinafina',30,2.00,'comprado'),
('tioconazol',30,4.00,'comprado'),
('dioxido de titanio',30,2.00,'comprado'),
('triclosan',60,2.00,'comprado'),
('acido borico',100,2.00,'comprado'),
('D-pantenol',30,5.00,'comprado'),
('tolnaftato',70,2.00,'comprado'),
('vitamina e',100,1.00,'comprado'),
('vitamina a',100,1.00,'comprado'),
('vitamina c',100,2.00,'comprado'),
('vitamina B1',100,2.00,'comprado'),
('urea',50,2.00,'comprado'),
('panadol',10,5.00,'comprado'),
('acetaminofen',20,1.00,'comprado'),
('dolofin',50,2.25,'comprado'),
('aescina',5,1.50,'comprado'),
('alantoina',10,2.50,'comprado'),
('alcinato de sodio',15,1.00,'comprado'),
('amorolfina',5,3.50,'comprado'),
('azufre',3,2.50,'comprado'),
('bifonazol',50,1.25,'comprado'),
('bisacodilo',45,1.50,'comprado'),
('aescina',5,1.50,'comprado'),
('bromhexina clorhidrato',10,5.00,'comprado'),
('calcio',5,2.50,'comprado'),
('vitaminaD3',20,1.00,'comprado'),
('casantranol',20,1.50,'comprado'),
('carbocisteina',10,2.00,'comprado'),
('carbonato de calcio',2,1.00,'comprado'),
('acetil',6,1.50,'comprado'),
('cetilpiridino',5,1.50,'comprado'),
('cipermetrina',100,1.00,'comprado'),
('clobutinol',50,0.50,'comprado'),
('clotimazol',15,1.00,'comprado'),
('desloratadina',30,1.50,'comprado'),
('diclofenaco',55,1.00,'comprado'),
('dimenhidrinato',90,0.50,'comprado'),
('dimeticona',80,1.50,'comprado'),
('econazol',56,6.50,'comprado'),
('etofenamato',4,3.50,'comprado'),
('esomeprazol',3,8.50,'comprado'),
('eucalipto',100,0.50,'comprado'),
('mentol',500,0.25,'comprado'),
('famotidina',5,6.50,'comprado'),
('fenol',100,1.00,'comprado'),
('fluoruro',20,1.50,'comprado'),
('glicerina',5,2.50,'comprado'),
('glucomannan',35,1.00,'comprado'),
('hidroxido',45,7.50,'comprado'),
('ibuprofeno',200,1.00,'comprado'),
('ictamol',60,1.00,'comprado'),
('itraconazol',40,1.20,'comprado'),
('ketoconazol',50,1.00,'comprado'),
('lactasa',30,2.00,'comprado'),
('alantoina',10,2.50,'comprado'),
('alcinato de sodio',15,1.00,'comprado'),
('amorolfina',5,3.50,'comprado'),
('azufre',3,2.50,'comprado'),
('bifonazol',50,1.25,'comprado'),
('bisacodilo',45,1.50,'comprado'),
('aescina',5,1.50,'comprado'),
('bromhexina clorhidrato',10,5.00,'comprado'),
('calcio',5,2.50,'comprado'),
('vitaminaD3',20,1.00,'comprado'),
('casantranol',20,1.50,'comprado'),
('carbocisteina',10,2.00,'comprado'),
('carbonato de calcio',2,1.00,'comprado'),
('acetil',6,1.50,'comprado'),
('cetilpiridino',5,1.50,'comprado'),
('cipermetrina',100,1.00,'comprado'),
('clobutinol',50,0.50,'comprado'),
('clotimazol',15,1.00,'comprado'),
('desloratadina',30,1.50,'comprado'),
('diclofenaco',55,1.00,'comprado'),
('dimenhidrinato',90,0.50,'comprado'),
('dimeticona',80,1.50,'comprado'),
('econazol',56,6.50,'comprado'),
('etofenamato',4,3.50,'comprado'),
('esomeprazol',3,8.50,'comprado'),
('eucalipto',100,0.50,'comprado'),
('mentol',500,0.25,'comprado'),
('famotidina',5,6.50,'comprado'),
('fenol',100,1.00,'comprado'),
('fluoruro',20,1.50,'comprado'),
('glicerina',5,2.50,'comprado'),
('glucomannan',35,1.00,'comprado'),
('hidroxido',45,7.50,'comprado'),
('ibuprofeno',200,1.00,'comprado'),
('ictamol',60,1.00,'comprado'),
('itraconazol',40,1.20,'comprado'),
('ketoconazol',50,1.00,'comprado')
GO



---LLENAMOS LA BD CON ALGUNOS REGISTROS DE PACIENTES
insert into Pacientes (Nombres, Apellidos,DUI, Telefono, Correo, Sexo, FechaNacimiento,FechaIngreso, AlergiaMedicamento) 
values 
('Juan Luis','Perez Sosa',06587886-9,74851432,'juanperez@gmail.com','Masculino','16/05/2020 00:00:00','19/05/2023 17:00:20','Panadol'), 
('Maria Juana','lopez ortega',065897896-9,56348978,'maria@gmail.com','femenino','30/03/2000',getdate(),'acetaminofen'), 
('Marvin alexander','lopez andrade',06789896-9,76458934,'marvin@gmail.com','Masculino','20/02/1999',getdate(),'morfina'),
('carlos alberto','alexander peres',06583839-9,78563490,'calos@gmail.com','masculino','26/12/1888',getdate(),'dolonegrobion'),
('juan alberto','alexander peres',06583639-9,74563490,'alberto@gmail.com','masculino','26/11/1898',getdate(),'dolonegrobion'),
('luis anderson','Perez Sosa',06547886-9,74951432,'luis@gmail.com','Masculino','10/05/2023',getdate(),'Panadol'),
('lorena Juana','lopez lopez',065897996-9,56338978,'lorena@gmail.com','femenino','31/03/2000',getdate(),'acetaminofen'), 
('Juan guarnizo','Perez sandobal',06387886-9,74551432,'guarnizo@gmail.com','Masculino','01/06/1989',getdate(),'acetaminofen'), 
('antonia','sanchez ortega',065597896-9,76348978,'antonia@gmail.com','femenino','05/03/2001',getdate(),'acetaminofen'), 
('miguel','sosa Sosa',06587886-9,74891432,'miguel@gmail.com','Masculino','23/05/1988',getdate(),'Panadol'), 
('ronaldo francisco','lopez sosa',065397896-9,86348978,'ronal@gmail.com','masculino','30/03/2000',getdate(),'acetaminofen'), 
('johalmo','Perez perez',06589886-9,74891432,'perez@gmail.com','Masculino','16/05/2023',getdate(),'Panadol'), 
('Maria Juana','sanchez alvarenga',065847896-9,55348978,'alvarenga@gmail.com','femenino','30/03/2000',getdate(),'acetaminofen'), 
('hernesto','Perez Sosa',06487886-9,75851432,'hernesto@gmail.com','Masculino','12/05/2001',getdate(),'Panadol'), 
('francisco','baires baires',065897898-9,56348978,'baires@gmail.com','masculino','30/03/2000',getdate(),'acetaminofen'),
('Faron Olivarez','S�nchez Rodr�guez',06587386-9,74851632,'faron@gmail.com','Masculino','16/05/1888',getdate(),'aspirina'), 
('Vicenta Amparan','Garc�a Hern�ndez',0658971096-9,56358978,'vicenta@gmail.com','femenino','30/03/2001',getdate(),'paracetamol'), 
('Roderigo Tejera','GARCIA RODRIGUEZ',01587886-9,74852432,'tejera@gmail.com','Masculino','16/05/2005',getdate(),'ibuprofeno'), 
('tejera vicenta','lopez ortega',055897896-9,56341078,'tejeraV@gmail.com','femenino','30/03/2000',getdate(),'acetaminofen'), 
('olivarez roderigo','hernandez garcia',068878866-9,79851432,'hernandez@gmail.com','Masculino','16/05/1999',getdate(),'Panadol'),
('Bartolo Balderas','Alfonso Verdejo',065897898-9,56548978,'bartolo@gmail.com','femenino','30/03/2010',getdate(),'acetaminofen'),
('Jorge Landeros','Amadeo Zaragosa',06587896-9,74854432,'jorge@gmail.com','Masculino','23/05/1923',getdate(),'Paracetamol'), 
('Amadeo Zaragosa','lopez ortega',035897896-9,56348978,'Amadeo@gmail.com','masculino','30/03/1999',getdate(),'acetaminofen'), 
('Dantel Patron','Gutierre Villena',06587889-9,74831432,'dantel@gmail.com','Masculino','16/05/1997',getdate(),'captopril'), 
('Gutierre Villena','Yago Mar',065897866-9,56348970,'villena@gmail.com','femenino','10/03/2000',getdate(),'acetaminofen'),
('Juan Luis','Perez Sosa',06587886-9,74851432,'juanperez@gmail.com','Masculino','16/05/2023',getdate(),'Panadol'), 
('Maria Juana','lopez ortega',065897896-9,56348978,'maria@gmail.com','femenino','30/03/2000',getdate(),'acetaminofen'), 
('Marvin alexander','lopez andrade',06789896-9,76458934,'marvin@gmail.com','Masculino','20/02/1999',getdate(),'morfina'),
('carlos alberto','alexander peres',06583839-9,78563490,'calos@gmail.com','masculino','26/12/1888',getdate(),'dolonegrobion'),
('juan alberto','alexander peres',06583639-9,74563490,'alberto@gmail.com','masculino','26/11/1898',getdate(),'dolonegrobion'),
('luis anderson','Perez Sosa',06547886-9,74951432,'luis@gmail.com','Masculino','10/05/2023',getdate(),'Panadol'),
('lorena Juana','lopez lopez',065897996-9,56338978,'lorena@gmail.com','femenino','31/03/2000',getdate(),'acetaminofen'), 
('Juan guarnizo','Perez sandobal',06387886-9,74551432,'guarnizo@gmail.com','Masculino','01/06/1989',getdate(),'acetaminofen'), 
('antonia','sanchez ortega',065597896-9,76348978,'antonia@gmail.com','femenino','05/03/2001',getdate(),'acetaminofen'), 
('miguel','sosa Sosa',06587886-9,74891432,'miguel@gmail.com','Masculino','23/05/1988',getdate(),'Panadol'), 
('ronaldo francisco','lopez sosa',065397896-9,86348978,'ronal@gmail.com','masculino','30/03/2000',getdate(),'acetaminofen'), 
('johalmo','Perez perez',06589886-9,74891432,'perez@gmail.com','Masculino','16/05/2023',getdate(),'Panadol'), 
('Maria Juana','sanchez alvarenga',065847896-9,55348978,'alvarenga@gmail.com','femenino','30/03/2000',getdate(),'acetaminofen'), 
('hernesto','Perez Sosa',06487886-9,75851432,'hernesto@gmail.com','Masculino','12/05/2001',getdate(),'Panadol'), 
('francisco','baires baires',065897898-9,56348978,'baires@gmail.com','masculino','30/03/2000',getdate(),'acetaminofen'),
('Faron Olivarez','S�nchez Rodr�guez',06587386-9,74851632,'faron@gmail.com','Masculino','16/05/1888',getdate(),'aspirina'), 
('Vicenta Amparan','Garc�a Hern�ndez',0658971096-9,56358978,'vicenta@gmail.com','femenino','30/03/2001',getdate(),'paracetamol'), 
('Roderigo Tejera','GARCIA RODRIGUEZ',01587886-9,74852432,'tejera@gmail.com','Masculino','16/05/2005',getdate(),'ibuprofeno'), 
('tejera vicenta','lopez ortega',055897896-9,56341078,'tejeraV@gmail.com','femenino','30/03/2000',getdate(),'acetaminofen'), 
('olivarez roderigo','hernandez garcia',06887886-9,79851432,'hernandez@gmail.com','Masculino','16/05/1999',getdate(),'Panadol'),
('Bartolo Balderas','Alfonso Verdejo',065897898-9,56548978,'bartolo@gmail.com','femenino','30/03/2010',getdate(),'acetaminofen'), 
('Jorge Landeros','Amadeo Zaragosa',06587896-9,74854432,'jorge@gmail.com','Masculino','23/05/1923',getdate(),'Paracetamol'), 
('Amadeo Zaragosa','lopez ortega',035897896-9,56348978,'Amadeo@gmail.com','masculino','30/03/1999',getdate(),'acetaminofen'), 
('Dantel Patron','Gutierre Villena',06587889-9,74831432,'dantel@gmail.com','Masculino','16/05/1997',getdate(),'captopril'), 
('Gutierre Villena','Yago Mar',065897866-9,56348970,'villena@gmail.com','femenino','10/03/2000',getdate(),'acetaminofen'),
('Juan Luis','Perez Sosa',06587886-9,74851432,'juanperez@gmail.com','Masculino','16/05/2023',getdate(),'Panadol'), 
('Maria Juana','lopez ortega',065897896-9,56348978,'maria@gmail.com','femenino','30/03/2000',getdate(),'acetaminofen'), 
('Marvin alexander','lopez andrade',06789896-9,76458934,'marvin@gmail.com','Masculino','20/02/1999',getdate(),'morfina'),
('carlos alberto','alexander peres',06583839-9,78563490,'calos@gmail.com','masculino','26/12/1888',getdate(),'dolonegrobion'),
('juan alberto','alexander peres',06583639-9,74563490,'alberto@gmail.com','masculino','26/11/1898',getdate(),'dolonegrobion'),
('luis anderson','Perez Sosa',06547886-9,74951432,'luis@gmail.com','Masculino','10/05/2023',getdate(),'Panadol'),
('lorena Juana','lopez lopez',065897996-9,56338978,'lorena@gmail.com','femenino','31/03/2000',getdate(),'acetaminofen'), 
('Juan guarnizo','Perez sandobal',06387886-9,74551432,'guarnizo@gmail.com','Masculino','01/06/1989',getdate(),'acetaminofen'), 
('antonia','sanchez ortega',065597896-9,76348978,'antonia@gmail.com','femenino','05/03/2001',getdate(),'acetaminofen'), 
('miguel','sosa Sosa',06587886-9,74891432,'miguel@gmail.com','Masculino','23/05/1988',getdate(),'Panadol'), 
('ronaldo francisco','lopez sosa',065397896-9,86348978,'ronal@gmail.com','masculino','30/03/2000',getdate(),'acetaminofen'), 
('johalmo','Perez perez',06589886-9,74891432,'perez@gmail.com','Masculino','16/05/2023',getdate(),'Panadol'), 
('Maria Juana','sanchez alvarenga',065847896-9,55348978,'alvarenga@gmail.com','femenino','30/03/2000',getdate(),'acetaminofen'), 
('hernesto','Perez Sosa',06487886-9,75851432,'hernesto@gmail.com','Masculino','12/05/2001',getdate(),'Panadol'),
GO

select * from  Pacientes