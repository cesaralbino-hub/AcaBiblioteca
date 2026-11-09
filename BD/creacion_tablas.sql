USE AcaBiblioteca;
GO

-- 1. TABLA AUTORES
CREATE TABLE Autores
(
    Id_Autor INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL
);

-- 2. TABLA EDITORIALES
CREATE TABLE Editoriales
(
    Id_Editorial INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(150) NOT NULL
);

-- 3. TABLA LIBROS
CREATE TABLE Libros
(
    ISBN VARCHAR(20) PRIMARY KEY,
    Titulo VARCHAR(200) NOT NULL,
    Id_Autor INT NOT NULL,
    Id_Editorial INT NOT NULL,
    Categoria VARCHAR(100),
    Anio INT,
    Existencias INT NOT NULL,

    CONSTRAINT FK_Libros_Autores
        FOREIGN KEY (Id_Autor)
        REFERENCES Autores(Id_Autor),

    CONSTRAINT FK_Libros_Editoriales
        FOREIGN KEY (Id_Editorial)
        REFERENCES Editoriales(Id_Editorial)
);

-- 4. TABLA USUARIOS
CREATE TABLE Usuarios
(
    Id_Usuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Documento VARCHAR(30) NOT NULL UNIQUE,
    Telefono1 VARCHAR(30),
    Correo VARCHAR(150)
);

-- 5. TABLA PRESTAMOS
CREATE TABLE Prestamos
(
    Id_Prestamo INT IDENTITY(1,1) PRIMARY KEY,
    Id_Usuario INT NOT NULL,
    ISBN VARCHAR(20) NOT NULL,
    Fecha_Prestamo DATE NOT NULL,
    Fecha_Devolucion DATE NULL,
    Estado VARCHAR(20) NOT NULL,

    CONSTRAINT FK_Prestamos_Usuarios
        FOREIGN KEY (Id_Usuario)
        REFERENCES Usuarios(Id_Usuario),

    CONSTRAINT FK_Prestamos_Libros
        FOREIGN KEY (ISBN)
        REFERENCES Libros(ISBN)
);