package Depozyt;

import org.hibernate.HibernateException;
import org.hibernate.engine.spi.SharedSessionContractImplementor;
import org.hibernate.id.IdentifierGenerator;

import java.io.Serializable;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class SmallestAvailableIdGenerator implements IdentifierGenerator {

    @Override
    public Serializable generate(SharedSessionContractImplementor session, Object object) throws HibernateException {
        Connection connection = session.connection();
        try (PreparedStatement ps = connection.prepareStatement(
                "SELECT MIN(t1.id+1) FROM Przedmioty t1 LEFT JOIN Przedmioty t2 ON t1.id + 1 = t2.id WHERE t2.id IS NULL")) {
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                int id = rs.getInt(1);
                return id > 0 ? id : 1;
            }
        } catch (SQLException e) {
            throw new HibernateException("Unable to generate ID", e);
        }
        return 1; //
    }
}
