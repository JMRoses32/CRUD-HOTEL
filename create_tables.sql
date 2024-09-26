-- Creación de tablas
create table Hotel
(Id_Hotel  int primary key, 
Nombre    char(40),    
Calle     char(30),           
Número    varchar (9),           
Ciudad    char(20),            
Estado    char(20),           
CP   int,
WWW varchar (40),
Teléfono_Recepción bigint,
Teléfono_Reserva bigint,
Categoría char (40))           

create table Habitación
(Id_Habitación  int primary key, 
Tipo_Habitación char(40),    
Descripción     char(50),           
No_Personas     int,           
Id_Hotel        int references Hotel(Id_Hotel),            
Precio          int)

create table Huésped
(Id_Huésped  int primary key, 
Nombre   char(35),    
Apellido_P char(35),    
Apellido_M char(35),           
Tel_Cel    bigint,        
Tel_Fijo    bigint,    
Calle     char(30),           
Número    varchar (9),
Colonia   char(30),           
Ciudad    char(20),            
Estado    char(20),           
CP        int)

create table Pagos
(Id_Pago  int primary key, 
Tipo   char(35),    
No_Tarjeta char(40),    
Fecha_Exp date)

create table Reserva
(Id_Reserva  int primary key,
Id_Huésped  int references Huésped(Id_Huésped), 
Id_Habitación  int references Habitación(Id_Habitación),   
Fecha_Entrada date,
Fecha_Salida date,
Días int,
Costo money,
Id_Pago  int references Pagos(Id_Pago), 
Estado_Pago char(30))

-- Insertar datos en la tabla Hotel
insert into Hotel (Id_Hotel, Nombre, Calle, Número, Ciudad, Estado, CP, WWW, Teléfono_Recepción, Teléfono_Reserva, Categoría) values
(1, 'Hotel Paradise', 'Sunset Blvd', '123', 'Los Angeles', 'California', 90001, 'www.hotelparadise.com', 1234567890, 1234567891, '5 Estrellas'),
(2, 'Hotel Blue Lagoon', 'Ocean Drive', '456', 'Miami', 'Florida', 33101, 'www.bluelagoon.com', 2345678901, 2345678902, '4 Estrellas'),
(3, 'Mountain Retreat', 'Pine St', '789', 'Denver', 'Colorado', 80201, 'www.mountainretreat.com', 3456789012, 3456789013, '3 Estrellas'),
(4, 'City Central', 'Main St', '101', 'New York', 'New York', 10001, 'www.citycentral.com', 4567890123, 4567890124, '4 Estrellas'),
(5, 'Beachside Inn', 'Beach Rd', '202', 'San Diego', 'California', 92101, 'www.beachsideinn.com', 5678901234, 5678901235, '3 Estrellas'),
(6, 'Desert Oasis', 'Cactus Ave', '303', 'Phoenix', 'Arizona', 85001, 'www.desertoasis.com', 6789012345, 6789012346, '5 Estrellas'),
(7, 'Lakeside Hotel', 'Lake View Dr', '404', 'Chicago', 'Illinois', 60601, 'www.lakesidehotel.com', 7890123456, 7890123457, '4 Estrellas')

-- Insertar datos en la tabla Habitación
insert into Habitación (Id_Habitación, Tipo_Habitación, Descripción, No_Personas, Id_Hotel, Precio) values
(1, 'Suite', 'Habitación con vista al mar', 4, 1, 300),
(2, 'Deluxe', 'Habitación con jacuzzi', 2, 1, 200),
(3, 'Standard', 'Habitación estándar', 2, 2, 150),
(4, 'Family', 'Habitación familiar', 6, 2, 250),
(5, 'Suite', 'Habitación con vista a la montaña', 4, 3, 350),
(6, 'Deluxe', 'Habitación en el centro de la ciudad', 2, 4, 220),
(7, 'Standard', 'Habitación económica', 2, 5, 100)

-- Insertar datos en la tabla Huésped
insert into Huésped (Id_Huésped, Nombre, Apellido_P, Apellido_M, Tel_Cel, Tel_Fijo, Calle, Número, Colonia, Ciudad, Estado, CP) values
(1, 'John', 'Doe', 'Smith', 1234567890, 9876543210, 'Main St', '789', 'Downtown', 'Los Angeles', 'California', 90001),
(2, 'Jane', 'Roe', 'Johnson', 2345678901, 8765432109, 'Broadway', '101', 'Midtown', 'Miami', 'Florida', 33101),
(3, 'Alice', 'Brown', 'Williams', 3456789012, 7654321098, 'Pine St', '102', 'Hillside', 'Denver', 'Colorado', 80201),
(4, 'Bob', 'Green', 'Taylor', 4567890123, 6543210987, 'Maple St', '103', 'Greenfield', 'New York', 'New York', 10001),
(5, 'Charlie', 'Black', 'Anderson', 5678901234, 5432109876, 'Oak St', '104', 'Seaside', 'San Diego', 'California', 92101),
(6, 'David', 'White', 'Thomas', 6789012345, 4321098765, 'Elm St', '105', 'Desertview', 'Phoenix', 'Arizona', 85001),
(7, 'Eve', 'Gray', 'Moore', 7890123456, 3210987654, 'Cedar St', '106', 'Lakeside', 'Chicago', 'Illinois', 60601)

-- Insertar datos en la tabla Pagos
insert into Pagos (Id_Pago, Tipo, No_Tarjeta, Fecha_Exp) values
(1, 'Tarjeta de Crédito', '1234-5678-9101-1121', '2025-12-01'),
(2, 'Tarjeta de Débito', '2345-6789-1011-1213', '2024-08-01'),
(3, 'Tarjeta de Crédito', '3456-7890-1121-1314', '2026-01-01'),
(4, 'Tarjeta de Débito', '4567-8901-1213-1415', '2023-06-01'),
(5, 'Tarjeta de Crédito', '5678-9012-1314-1516', '2025-07-01'),
(6, 'Tarjeta de Débito', '6789-0123-1415-1617', '2024-05-01'),
(7, 'Tarjeta de Crédito', '7890-1234-1516-1718', '2026-09-01')

-- Insertar datos en la tabla Reserva
insert into Reserva (Id_Reserva, Id_Huésped, Id_Habitación, Fecha_Entrada, Fecha_Salida, Días, Costo, Id_Pago, Estado_Pago) values
(1, 1, 1, '2024-06-01', '2024-06-07', 6, 1800.00, 1, 'Pagado'),
(2, 2, 3, '2024-07-15', '2024-07-20', 5, 750.00, 2, 'Pendiente'),
(3, 3, 5, '2024-08-10', '2024-08-17', 7, 2450.00, 3, 'Pagado'),
(4, 4, 6, '2024-09-05', '2024-09-10', 5, 1100.00, 4, 'Pagado'),
(5, 5, 7, '2024-10-01', '2024-10-07', 6, 600.00, 5, 'Pendiente'),
(6, 6, 2, '2024-11-12', '2024-11-18', 6, 1200.00, 6, 'Pagado'),
(7, 7, 4, '2024-12-20', '2024-12-25', 5, 1250.00, 7, 'Pagado')

select*from Hotel
select*from Habitación
select*from Huésped
select*from Pagos
select*from Reserva
