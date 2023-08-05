import pyodbc

def insert_into_documentos(factura, condicion, cliente, fecha, monto, estado):
    connection_string = 'Driver={SQL Server};Server=RAYMERSEGURA\SQLEXPRESS;Database=PRACTICA8;UID=Login_Admin;PWD=unlock123'
    connection = pyodbc.connect(connection_string)
    cursor = connection.cursor()

    try:
        insert_sql = "INSERT INTO documentos (factura, condicion, cliente, fecha, monto, estado) VALUES (?, ?, ?, ?, ?, ?)"
        data = (factura, condicion, cliente, fecha, monto, estado)

        cursor.execute(insert_sql, data)
        connection.commit()
        print("¡Guardado correctamente!")
    except pyodbc.Error as error:
        print("Error:", error)
        connection.rollback()
    finally:
        cursor.close()
        connection.close()

if __name__ == "__main__":
    import sys
    if len(sys.argv) != 7:
        print("Uso: python insert.py factura condicion cliente fecha monto estado")
    else:
        factura = int(sys.argv[1])
        condicion = sys.argv[2]
        cliente = sys.argv[3]
        fecha = sys.argv[4]
        monto = float(sys.argv[5])
        estado = sys.argv[6]

        insert_into_documentos(factura, condicion, cliente, fecha, monto, estado)
