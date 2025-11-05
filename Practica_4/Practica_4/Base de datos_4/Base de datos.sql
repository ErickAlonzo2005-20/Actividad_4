-- Crear la base de datos
CREATE DATABASE Practica4; 
GO 
USE Practica4; 
GO 
CREATE TABLE Categorias ( 
CategoriaID INT PRIMARY KEY IDENTITY(1,1), 
NombreCategoria VARCHAR(50) NOT NULL 
); 
CREATE TABLE Productos ( 
ProductoID INT PRIMARY KEY IDENTITY(1,1), 
NombreProducto VARCHAR(100) NOT NULL, 
Descripcion VARCHAR(255) NULL, 
Precio DECIMAL(10,2) NOT NULL, 
Stock INT NOT NULL DEFAULT 0, 
CategoriaID INT NULL, 
FOREIGN KEY (CategoriaID) REFERENCES Categorias(CategoriaID) 
); 
CREATE TABLE Clientes ( 
ClienteID INT PRIMARY KEY IDENTITY(1,1), 
NombreCompleto VARCHAR(150) NOT NULL, 
CorreoElectronico VARCHAR(100) NULL, 
Telefono VARCHAR(15) NULL, 
Direccion VARCHAR(255) NULL 
); 
CREATE TABLE Proveedores ( 
ProveedorID INT PRIMARY KEY IDENTITY(1,1), 
NombreProveedor VARCHAR(100) NOT NULL, 
Telefono VARCHAR(15) NULL, 
CorreoElectronico VARCHAR(100) NULL 
); 
GO 
INSERT INTO Categorias (NombreCategoria) VALUES 
('Mobiliario'),          
('Libros'),              
('Deportes'),            
('Jardinería'),           
('Higiene Personal'),    
('Herramientas');        
INSERT INTO Productos (NombreProducto, Descripcion, Precio, Stock, 
CategoriaID) VALUES 
('Lámpara de Pie', 'Lámpara moderna con base de metal', 65.50, 30, 1), 
('Estantería Modular', 'Estantería de 4 niveles, fácil montaje', 110.00, 12, 1), 
('Biografía Histórica', 'Vida y obra de un líder político del siglo XX', 30.00, 60, 2), 
('Libro de Cocina Vegana', 'Recetas sencillas y saludables', 22.75, 40, 2), 
('Cuerda para Saltar', 'Cuerda ajustable con agarres acolchados', 12.00, 90, 3), 
('Pesas de Mano (2kg)', 'Juego de dos pesas de neopreno', 40.00, 35, 3), 
('Tierra para Macetas', 'Saco de 20kg de tierra fertilizada', 8.50, 150, 4), 
('Set de Herramientas de Jardín', 'Pala, rastrillo y cultivador pequeños', 28.00, 40, 
4), 
('Champú Orgánico', 'Champú sin sulfatos de 500ml', 18.00, 75, 5), 
('Jabón Artesanal', 'Jabón con aceites esenciales, 100g', 5.00, 200, 5), 
('Destornillador Phillips', 'Destornillador de precisión #2', 14.00, 110, 6); 
INSERT INTO Clientes (NombreCompleto, CorreoElectronico, Telefono, Direccion) 
VALUES 
('Carla Nuñez', 'carla.n@dominio.com', '8291238899', 'Urb. Paraíso, Edif. B, Apt. 
10'), 
('Roberto Gómez', 'robertogomez@mail.com', '8494001010', 'Carretera Vieja, Km 
7'), 
('Laura Peña', 'laura.p@webmail.net', '8097072020', 'Calle Principal #50, 
Ensanche'); 
INSERT INTO Proveedores (NombreProveedor, Telefono, CorreoElectronico) 
VALUES 
('Maderas del Este', '8099990000', 'contacto@maderas.com'), 
('Editorial del Saber', '8291013030', 'ventas@elsaber.net'), 
('Green Supplies S.R.L.', '8498889999', 'info@greensupplies.com');