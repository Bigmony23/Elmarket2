{
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                string query = @"
BEGIN
    -- Check if data already exists in Fakt_Ostatki for today
    IF NOT EXISTS (
        SELECT 1
        FROM Fakt_Ostatki AS f
        INNER JOIN Rasxod1 AS r ON f.Id_Product = r.Id_Product
        INNER JOIN Tek_Ostatki AS t ON r.Id_Product = t.Id_Product
        WHERE f.Datanum = t.Datanum
    )
    BEGIN
        -- Insert data into Fakt_Ostatki
        INSERT INTO Fakt_Ostatki (
            Id_Product,
            Sena_prodaji,
            kolichestvo,
            Datanum
            
           
        )
        SELECT
            r.Id_Product,
            r.Sena_prodaji,
            r.Data_Prixoda
            t.kolichestvo - r.Kolichestvo
            t.Datanum

        FROM
            Rasxod1 AS r
        INNER JOIN
            Tek_Ostatki AS t
        ON
            r.Id_Product = t.Id_Product;
    END
    ELSE
    BEGIN
        -- If data exists, return a custom message
        SELECT 'DataAlreadyExists' AS Message;
    END
END";

                using (SqlCommand command = new SqlCommand(query, connection, transaction))
                {
                    try
                    {
                        // Execute the query and check the result
                        object result = command.ExecuteScalar();

                        if (result != null && ((string)result) == "DataAlreadyExists")
                        {
                            MessageBox.Show("Данные уже существуют на сегодняшний день.");
                        }
                        else
                        {
                            // Check for negative balance after insertion
                            string checkNegativeBalanceQuery = @"
                SELECT COUNT(*)
                FROM Fakt_Ostatki
                WHERE kolichestvo < 0";

                            using (SqlCommand checkCommand = new SqlCommand(checkNegativeBalanceQuery, connection, transaction))
                            {
                                int negativeBalanceCount = (int)checkCommand.ExecuteScalar();
                                if (negativeBalanceCount > 0)
                                {
                                    MessageBox.Show("Обнаружен негативный остаток");
                                }
                                else
                                {
                                    // Commit the transaction
                                    transaction.Commit();
                                    MessageBox.Show("Данные добавлены");
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Rollback the transaction in case of an error
                        transaction.Rollback();
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
        }