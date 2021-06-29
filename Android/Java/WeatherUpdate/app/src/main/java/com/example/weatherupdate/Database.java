package com.example.weatherupdate;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import androidx.appcompat.app.AppCompatActivity;

import java.sql.SQLException;

public abstract class Database extends AppCompatActivity {
    protected void initDb() throws SQLException {
        SQLiteDatabase db=
                SQLiteDatabase.openOrCreateDatabase(
                        getFilesDir().getPath()+"/weatherupdateDB.db",
                        null
                );
        String createQuery="CREATE TABLE if not exists WeatherUpdate( " +
                "ID integer PRIMARY KEY AUTOINCREMENT, " +
                "City text not null " +
                "); ";
        db.execSQL(createQuery);
        db.close();
    }

    protected void ExecSQL(String SQL, Object[] args, OnQuerySuccess success) throws SQLException{
        SQLiteDatabase db=
                SQLiteDatabase.openOrCreateDatabase(
                        getFilesDir().getPath()+"/weatherupdateDB.db",
                        null
                );

        db.execSQL(SQL, args);
        success.OnSuccess();
        db.close();
    }

    public void SelectSQL(String SQL, String[] args, OnSelectElement iterate)
            throws Exception
    {
        SQLiteDatabase db=
                SQLiteDatabase.openOrCreateDatabase(
                        getFilesDir().getPath()+"/weatherupdateDB.db",
                        null
                );

        Cursor cursor=db.rawQuery(SQL, args);
        while (cursor.moveToNext()){
            String ID = cursor.getString(cursor.getColumnIndex("ID"));
            String City = cursor.getString(cursor.getColumnIndex("City"));
            iterate.OnElementIterate(City, ID);
        }
        db.close();

    }

    protected interface OnQuerySuccess{
        public void OnSuccess();
    }

    protected interface OnSelectElement{
        public void OnElementIterate(String City, String ID);
    }
}
