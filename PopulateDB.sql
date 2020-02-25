
INSERT INTO Company VALUES (1,'BrainWare Company')
INSERT INTO Product VALUES (1,'Pipe fitting',1.23)
INSERT INTO Product VALUES (2,'10" straight',2.00)
INSERT INTO Product VALUES (3,'Quarter turn',0.75)
INSERT INTO Product VALUES (4,'5" straight',1.1)
INSERT INTO Product VALUES (5,'2" stright',0.90)

INSERT INTO [Order] VALUES ('Our first order.', 1)
INSERT INTO [OrderProduct] VALUES (1, 1, 1.23, 10)
INSERT INTO [OrderProduct] VALUES (1, 3, 1.00, 3)
INSERT INTO [OrderProduct] VALUES (1, 4, 1.1, 22)

INSERT INTO [Order] VALUES ('Our Second order.', 1)
INSERT INTO [OrderProduct] VALUES (2, 1, 1.23, 10)
INSERT INTO [OrderProduct] VALUES (2, 3, 1.00, 3)
INSERT INTO [OrderProduct] VALUES (2, 2, 2, 13)
INSERT INTO [OrderProduct] VALUES (2, 5, 0.9, 3)


INSERT INTO [Order] VALUES ('Our third order.', 1)

INSERT INTO [OrderProduct] VALUES (3, 1, 1.23, 10)
INSERT INTO [OrderProduct] VALUES (3, 2, 2.00, 7)
INSERT INTO [OrderProduct] VALUES (3, 3, 0.75, 13)
INSERT INTO [OrderProduct] VALUES (3, 4, 1.1, 5)
INSERT INTO [OrderProduct] VALUES (3, 5, 0.9, 3)


