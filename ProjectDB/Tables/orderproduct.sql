CREATE TABLE [dbo].[orderproduct]
(
	[order_id] int NOT NULL,
	[product_id] int NOT NULL,
	[price] decimal(18,2) NOT NULL,
	[quantity] int NOT NULL, 
    CONSTRAINT [PK_orderproduct] PRIMARY KEY ([order_id], [product_id]), 
    CONSTRAINT [FK_orderproduct_product] FOREIGN KEY ([product_id]) REFERENCES [product]([product_id]), 
    CONSTRAINT [FK_orderproduct_order] FOREIGN KEY ([order_id]) REFERENCES [order]([order_id])
)
