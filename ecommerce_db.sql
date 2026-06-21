-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 20-Jun-2026 às 17:37
-- Versão do servidor: 10.4.32-MariaDB
-- versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `ecommerce_db`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `carrinhos`
--

CREATE TABLE `carrinhos` (
  `id` int(11) NOT NULL,
  `cliente_id` int(11) DEFAULT NULL,
  `data_criacao` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `carrinhos`
--

INSERT INTO `carrinhos` (`id`, `cliente_id`, `data_criacao`) VALUES
(1, 1, '2026-06-14 15:09:34'),
(2, 2, '2026-06-16 11:34:25'),
(3, 4, '2026-06-18 12:18:11'),
(4, 3, '2026-06-18 14:01:09');

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `telefone` varchar(20) DEFAULT NULL,
  `endereco` text DEFAULT NULL,
  `data_registo` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`id`, `nome`, `email`, `telefone`, `endereco`, `data_registo`) VALUES
(1, 'José Manuel', 'jose@email.com', '923000000', NULL, '2026-06-14 15:09:34'),
(2, 'Maria Silva', 'maria@email.com', '924000000', NULL, '2026-06-14 15:09:34'),
(3, 'Lourenço', 'lourenco@email.com', '999999', 'Uíge', '2026-06-16 07:56:02'),
(4, 'André Matos', 'am@gmail.com', '999999999', 'Bairro tal, jierhowj', '2026-06-18 09:28:15');

-- --------------------------------------------------------

--
-- Estrutura da tabela `devolucoes`
--

CREATE TABLE `devolucoes` (
  `id` int(11) NOT NULL,
  `encomenda_id` int(11) DEFAULT NULL,
  `data_devolucao` timestamp NOT NULL DEFAULT current_timestamp(),
  `motivo` text DEFAULT NULL,
  `valor_reembolso` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `devolucoes`
--

INSERT INTO `devolucoes` (`id`, `encomenda_id`, `data_devolucao`, `motivo`, `valor_reembolso`) VALUES
(1, 1, '2026-06-14 15:09:34', 'Produto com defeito', 8000.00);

-- --------------------------------------------------------

--
-- Estrutura da tabela `encomendas`
--

CREATE TABLE `encomendas` (
  `id` int(11) NOT NULL,
  `cliente_id` int(11) DEFAULT NULL,
  `data_encomenda` timestamp NOT NULL DEFAULT current_timestamp(),
  `estado` enum('PENDENTE','CONFIRMADA','EXPEDIDA','ENTREGUE','CANCELADA') DEFAULT 'PENDENTE',
  `total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `encomendas`
--

INSERT INTO `encomendas` (`id`, `cliente_id`, `data_encomenda`, `estado`, `total`) VALUES
(1, 1, '2026-06-14 15:09:34', 'PENDENTE', 31000.00),
(7, 2, '2026-06-18 12:55:07', 'PENDENTE', 3376800.00),
(8, 2, '2026-06-18 12:55:16', 'PENDENTE', 554800.00),
(9, 1, '2026-06-18 12:57:18', 'PENDENTE', 675800.00),
(10, 1, '2026-06-18 13:59:56', 'PENDENTE', 25000.00),
(11, 3, '2026-06-18 14:01:34', 'PENDENTE', 4386000.00),
(12, 1, '2026-06-18 14:07:15', 'PENDENTE', 0.00),
(13, 2, '2026-06-20 12:36:37', 'PENDENTE', 327400.00),
(14, 4, '2026-06-20 12:45:38', 'PENDENTE', 622800.00),
(15, 2, '2026-06-20 13:02:47', 'PENDENTE', 857200.00),
(16, 4, '2026-06-20 13:21:00', 'PENDENTE', 574800.00);

-- --------------------------------------------------------

--
-- Estrutura da tabela `itens_carrinho`
--

CREATE TABLE `itens_carrinho` (
  `id` int(11) NOT NULL,
  `carrinho_id` int(11) DEFAULT NULL,
  `produto_id` int(11) DEFAULT NULL,
  `quantidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `itens_carrinho`
--

INSERT INTO `itens_carrinho` (`id`, `carrinho_id`, `produto_id`, `quantidade`) VALUES
(20, 1, 1, 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `itens_encomenda`
--

CREATE TABLE `itens_encomenda` (
  `id` int(11) NOT NULL,
  `encomenda_id` int(11) DEFAULT NULL,
  `produto_id` int(11) DEFAULT NULL,
  `quantidade` int(11) DEFAULT NULL,
  `preco_unitario` decimal(10,2) DEFAULT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `itens_encomenda`
--

INSERT INTO `itens_encomenda` (`id`, `encomenda_id`, `produto_id`, `quantidade`, `preco_unitario`, `subtotal`) VALUES
(1, 1, 1, 1, 15000.00, 15000.00),
(2, 1, 2, 2, 8000.00, 16000.00),
(3, 7, 2, 6, 8000.00, 48000.00),
(4, 7, 4, 10, 277400.00, 2774000.00),
(5, 7, 4, 2, 277400.00, 554800.00),
(6, 8, 4, 2, 277400.00, 554800.00),
(7, 9, 1, 1, 15000.00, 15000.00),
(8, 9, 1, 1, 15000.00, 15000.00),
(9, 9, 1, 1, 15000.00, 15000.00),
(10, 9, 1, 1, 15000.00, 15000.00),
(11, 9, 1, 1, 15000.00, 15000.00),
(12, 9, 1, 2, 15000.00, 30000.00),
(13, 9, 1, 0, 15000.00, 0.00),
(14, 9, 2, 2, 8000.00, 16000.00),
(15, 9, 4, 2, 277400.00, 554800.00),
(16, 10, 1, 1, 15000.00, 15000.00),
(17, 10, 3, 2, 5000.00, 10000.00),
(18, 11, 1, 15, 15000.00, 225000.00),
(19, 11, 4, 15, 277400.00, 4161000.00),
(20, 13, 2, 5, 8000.00, 40000.00),
(21, 13, 3, 2, 5000.00, 10000.00),
(22, 13, 4, 1, 277400.00, 277400.00),
(23, 14, 1, 1, 15000.00, 15000.00),
(24, 14, 3, 3, 5000.00, 15000.00),
(25, 14, 1, 2, 15000.00, 30000.00),
(26, 14, 2, 1, 8000.00, 8000.00),
(27, 14, 4, 2, 277400.00, 554800.00),
(28, 15, 1, 1, 15000.00, 15000.00),
(29, 15, 3, 2, 5000.00, 10000.00),
(30, 15, 4, 3, 277400.00, 832200.00),
(31, 16, 1, 1, 15000.00, 15000.00),
(32, 16, 4, 2, 277400.00, 554800.00),
(33, 16, 3, 1, 5000.00, 5000.00);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `categoria` varchar(100) DEFAULT NULL,
  `preco` decimal(10,2) NOT NULL,
  `stock` int(11) NOT NULL,
  `peso` decimal(10,2) DEFAULT NULL,
  `data_criacao` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`id`, `nome`, `categoria`, `preco`, `stock`, `peso`, `data_criacao`) VALUES
(1, 'Arroz 25kg', 'Alimentos', 15000.00, 22, 25.00, '2026-06-14 15:09:34'),
(2, 'Açúcar 10kg', 'Alimentos', 8000.00, 16, 10.00, '2026-06-14 15:09:34'),
(3, 'Óleo 5L', 'Alimentos', 5000.00, 10, 5.00, '2026-06-14 15:09:34'),
(4, 'Computador HP', 'Electrónicos', 277400.00, -19, 0.50, '2026-06-16 06:03:38');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `senha` varchar(100) DEFAULT NULL,
  `tipo` enum('ADMIN','CLIENTE') DEFAULT 'CLIENTE'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `email`, `senha`, `tipo`) VALUES
(2, 'José Wazia', 'jw@ec.com', '123', '');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `carrinhos`
--
ALTER TABLE `carrinhos`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `cliente_id` (`cliente_id`);

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Índices para tabela `devolucoes`
--
ALTER TABLE `devolucoes`
  ADD PRIMARY KEY (`id`),
  ADD KEY `encomenda_id` (`encomenda_id`);

--
-- Índices para tabela `encomendas`
--
ALTER TABLE `encomendas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `cliente_id` (`cliente_id`);

--
-- Índices para tabela `itens_carrinho`
--
ALTER TABLE `itens_carrinho`
  ADD PRIMARY KEY (`id`),
  ADD KEY `carrinho_id` (`carrinho_id`),
  ADD KEY `produto_id` (`produto_id`);

--
-- Índices para tabela `itens_encomenda`
--
ALTER TABLE `itens_encomenda`
  ADD PRIMARY KEY (`id`),
  ADD KEY `encomenda_id` (`encomenda_id`),
  ADD KEY `produto_id` (`produto_id`);

--
-- Índices para tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `carrinhos`
--
ALTER TABLE `carrinhos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `devolucoes`
--
ALTER TABLE `devolucoes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `encomendas`
--
ALTER TABLE `encomendas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de tabela `itens_carrinho`
--
ALTER TABLE `itens_carrinho`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT de tabela `itens_encomenda`
--
ALTER TABLE `itens_encomenda`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `carrinhos`
--
ALTER TABLE `carrinhos`
  ADD CONSTRAINT `carrinhos_ibfk_1` FOREIGN KEY (`cliente_id`) REFERENCES `clientes` (`id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `devolucoes`
--
ALTER TABLE `devolucoes`
  ADD CONSTRAINT `devolucoes_ibfk_1` FOREIGN KEY (`encomenda_id`) REFERENCES `encomendas` (`id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `encomendas`
--
ALTER TABLE `encomendas`
  ADD CONSTRAINT `encomendas_ibfk_1` FOREIGN KEY (`cliente_id`) REFERENCES `clientes` (`id`) ON DELETE SET NULL;

--
-- Limitadores para a tabela `itens_carrinho`
--
ALTER TABLE `itens_carrinho`
  ADD CONSTRAINT `itens_carrinho_ibfk_1` FOREIGN KEY (`carrinho_id`) REFERENCES `carrinhos` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `itens_carrinho_ibfk_2` FOREIGN KEY (`produto_id`) REFERENCES `produtos` (`id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `itens_encomenda`
--
ALTER TABLE `itens_encomenda`
  ADD CONSTRAINT `itens_encomenda_ibfk_1` FOREIGN KEY (`encomenda_id`) REFERENCES `encomendas` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `itens_encomenda_ibfk_2` FOREIGN KEY (`produto_id`) REFERENCES `produtos` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
