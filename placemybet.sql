-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-11-2019 a las 20:32:43
-- Versión del servidor: 10.4.8-MariaDB
-- Versión de PHP: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `placemybet`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `apuesta`
--

CREATE TABLE `apuesta` (
  `Id` int(11) NOT NULL,
  `Mercado` float NOT NULL,
  `Tipo` bit(1) NOT NULL,
  `Cuota` float NOT NULL,
  `Apostado` double NOT NULL,
  `Id_Mercado` int(11) NOT NULL,
  `Email` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `apuesta`
--

INSERT INTO `apuesta` (`Id`, `Mercado`, `Tipo`, `Cuota`, `Apostado`, `Id_Mercado`, `Email`) VALUES
(155, 1.5, b'1', 1.9, 5, 1, 'neila@gmail.com'),
(156, 3.5, b'0', 1.9, 20, 3, 'neila@gmail.com'),
(157, 3.5, b'1', 2.09, 5, 3, 'pepo@gmail.com'),
(158, 1.5, b'1', 1.5, 133, 12, 'anagarcia@gmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta`
--

CREATE TABLE `cuenta` (
  `Banco` varchar(20) NOT NULL,
  `Número tarjeta` bigint(20) NOT NULL,
  `Saldo` double NOT NULL,
  `Email` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cuenta`
--

INSERT INTO `cuenta` (`Banco`, `Número tarjeta`, `Saldo`, `Email`) VALUES
('Santander', 1234123412341234, 3019.23, 'anagarcia@gmail.com'),
('Bankia', 2312345645323455, 200.12, 'neila@gmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `evento`
--

CREATE TABLE `evento` (
  `Id` int(11) NOT NULL,
  `Fecha` datetime NOT NULL,
  `Local` varchar(20) NOT NULL,
  `Goles_Local` int(11) DEFAULT NULL,
  `Visitante` varchar(20) NOT NULL,
  `Goles_Visitante` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `evento`
--

INSERT INTO `evento` (`Id`, `Fecha`, `Local`, `Goles_Local`, `Visitante`, `Goles_Visitante`) VALUES
(1, '2019-11-17 19:05:00', 'Valencia', -1, 'Málaga', -1),
(2, '2019-11-20 22:32:00', 'Valencia', -1, 'Villareal', -1),
(4, '2019-11-29 22:39:00', 'Betis', -1, 'Sevilla', -1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mercado`
--

CREATE TABLE `mercado` (
  `Id` int(11) NOT NULL,
  `Mercado` float NOT NULL,
  `Cuota_Over` float NOT NULL,
  `Cuota_Under` float NOT NULL,
  `Dinero_Over` double NOT NULL,
  `Dinero_Under` double NOT NULL,
  `Id_Evento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mercado`
--

INSERT INTO `mercado` (`Id`, `Mercado`, `Cuota_Over`, `Cuota_Under`, `Dinero_Over`, `Dinero_Under`, `Id_Evento`) VALUES
(1, 1.5, 1.85476, 1.9475, 110, 100, 1),
(3, 3.5, 2.03571, 1.78125, 105, 120, 1),
(4, 1.5, 1.9, 1.9, 100, 100, 2),
(6, 3.5, 1.9, 1.9, 100, 100, 2),
(7, 2.5, 1.9, 1.9, 100, 100, 2),
(8, 2.5, 1.9, 1.9, 100, 100, 1),
(12, 1.5, 1.9, 1.9, 100, 100, 4),
(13, 2.5, 1.9, 1.9, 100, 100, 4),
(14, 3.5, 1.9, 1.9, 100, 100, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `Email` varchar(20) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apellidos` varchar(20) NOT NULL,
  `Edad` int(3) NOT NULL,
  `Fondos` double NOT NULL,
  `Administrador` bit(1) NOT NULL,
  `Password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`Email`, `Nombre`, `Apellidos`, `Edad`, `Fondos`, `Administrador`, `Password`) VALUES
('23', 's', 'ss', 2, 2, b'0', '222222'),
('anagarcia@gmail.com', 'Ana', 'García García', 23, 100, b'0', ''),
('andres@mm.com', 'Andres', 'Alfonso', 55, 0, b'0', 'Asdf.1'),
('fac@mm.com', 'Conchi', 'Plaza', 55, 0, b'0', 'Mm810.'),
('facturacion@mm.com', 'Conchi', 'Plaza', 55, 0, b'0', 'Mm810.'),
('juan@hotmail.com', 'Juan', 'Garcés', 23, 2300, b'0', ''),
('neila@gmail.com', 'Neila', 'Deba Aguirre', 25, 205, b'0', ''),
('nuevo@gmail.com', 'Felipe', 'Tomas', 29, 0, b'0', 'Abc123%'),
('pepo@gmail', 'e', 'e', 1, 1, b'1', '1'),
('pepo@gmail.com', 'Pepe', 'Ríos López', 30, 400, b'0', ''),
('rodrigo@mm.com', 'Rodrigo', 'Alberdi', 23, 50000, b'1', 'ABc123%'),
('salva@gmail.com', 'Salvador', 'Sanchez Mira', 34, 0, b'1', '2aBC123%');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `apuesta`
--
ALTER TABLE `apuesta`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Email` (`Email`),
  ADD KEY `Id_Mercado` (`Id_Mercado`);

--
-- Indices de la tabla `cuenta`
--
ALTER TABLE `cuenta`
  ADD PRIMARY KEY (`Número tarjeta`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indices de la tabla `evento`
--
ALTER TABLE `evento`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `mercado`
--
ALTER TABLE `mercado`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Id_Evento` (`Id_Evento`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Email`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `apuesta`
--
ALTER TABLE `apuesta`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=159;

--
-- AUTO_INCREMENT de la tabla `evento`
--
ALTER TABLE `evento`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `mercado`
--
ALTER TABLE `mercado`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `apuesta`
--
ALTER TABLE `apuesta`
  ADD CONSTRAINT `APUESTA_ibfk_2` FOREIGN KEY (`Email`) REFERENCES `usuario` (`Email`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `apuesta_ibfk_1` FOREIGN KEY (`Id_Mercado`) REFERENCES `mercado` (`Id`);

--
-- Filtros para la tabla `cuenta`
--
ALTER TABLE `cuenta`
  ADD CONSTRAINT `CUENTA_ibfk_1` FOREIGN KEY (`Email`) REFERENCES `usuario` (`Email`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `mercado`
--
ALTER TABLE `mercado`
  ADD CONSTRAINT `mercado_ibfk_1` FOREIGN KEY (`Id_Evento`) REFERENCES `evento` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
