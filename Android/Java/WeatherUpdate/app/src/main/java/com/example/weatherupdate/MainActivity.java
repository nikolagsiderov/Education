package com.example.weatherupdate;

import android.graphics.Color;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.sql.SQLException;
import java.text.DecimalFormat;
import java.util.ArrayList;

public class MainActivity extends Database {
    EditText etCity, etCountry;
    TextView tvResult;
    private final String url = "http://api.openweathermap.org/data/2.5/weather";
    private final String appid = "677ab8d211d6a20ff3f35205685aee8f";
    DecimalFormat df = new DecimalFormat("#.##");

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        etCity = findViewById(R.id.etCity);
        etCountry = findViewById(R.id.etCountry);
        tvResult = findViewById(R.id.tvResult);

        etCity.setTextColor(Color.parseColor("#ffffff"));
        etCity.setHintTextColor(Color.parseColor("#ffffff"));
        etCountry.setTextColor(Color.parseColor("#ffffff"));
        etCountry.setHintTextColor(Color.parseColor("#ffffff"));
        tvResult.setTextColor(Color.parseColor("#ffffff"));

        try {
            initDb();
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
    }

    public void getWeatherDetails(View view) {
        String tempUrl = "";
        String city = etCity.getText().toString().trim();
        String country = etCountry.getText().toString().trim();

        if (city.equals("")) {
            tvResult.setText("City field can not be empty!");
        } else {
            if (!country.equals("")) {
                tempUrl = url + "?q=" + city + "," + country + "&appid=" + appid;
            } else {
                tempUrl = url + "?q=" + city + "&appid=" + appid;
            }

            // Insert weather request in DB
            try {
                ExecSQL("INSERT INTO WeatherUpdate(City)" +
                                "VALUES(?)",
                        new Object[]{city},
                        () -> { /*Show toast message*/ }
                );
            } catch (SQLException throwables) {
                throwables.printStackTrace();
            }

            StringRequest stringRequest = new StringRequest(Request.Method.POST, tempUrl, new Response.Listener<String>() {
                @Override
                public void onResponse(String response) {
                    //Log.d("response", response);
                    String output = "";
                    try {
                        JSONObject jsonResponse = new JSONObject(response);
                        JSONArray jsonArray = jsonResponse.getJSONArray("weather");
                        JSONObject jsonObjectWeather = jsonArray.getJSONObject(0);
                        String description = jsonObjectWeather.getString("description");
                        JSONObject jsonObjectMain = jsonResponse.getJSONObject("main");
                        double temp = jsonObjectMain.getDouble("temp") - 273.15;
                        double feelsLike = jsonObjectMain.getDouble("feels_like") - 273.15;
                        float pressure = jsonObjectMain.getInt("pressure");
                        int humidity = jsonObjectMain.getInt("humidity");
                        JSONObject jsonObjectWind = jsonResponse.getJSONObject("wind");
                        String wind = jsonObjectWind.getString("speed");
                        JSONObject jsonObjectClouds = jsonResponse.getJSONObject("clouds");
                        String clouds = jsonObjectClouds.getString("all");
                        JSONObject jsonObjectSys = jsonResponse.getJSONObject("sys");
                        String countryName = jsonObjectSys.getString("country");
                        String cityName = jsonResponse.getString("name");

                        output += "Прогнозата " +
                                "за времето в " + cityName + " (" + countryName + ")"
                                + "\n Температура: " + df.format(temp) + " Целзий"
                                + "\n Усеща се като: " + df.format(feelsLike) + " Целзий"
                                + "\n Влажност: " + humidity + "%"
                                + "\n Детайли: " + description
                                + "\n Скорост на вятъра: " + wind + "m/s (метра в секунда)"
                                + "\n Облачност: " + clouds + "%"
                                + "\n Налягане: " + pressure + " hPa";
                        tvResult.setText(output);
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                }
            }, new Response.ErrorListener() {
                @Override
                public void onErrorResponse(VolleyError error) {
                    Toast.makeText(getApplicationContext(), error.toString().trim(), Toast.LENGTH_SHORT).show();
                }
            });
            RequestQueue requestQueue = Volley.newRequestQueue(getApplicationContext());
            requestQueue.add(stringRequest);
        }
    }

    public void getWeatherDetailsForPlovdiv(View view) {
        String city = "Plovdiv";
        String tempUrl = url + "?q=" + city + "&appid=" + appid;

        // Insert weather request in DB
        try {
            ExecSQL("INSERT INTO WeatherUpdate(City)" +
                            "VALUES(?)",
                    new Object[]{city},
                    () -> { /*Show toast message*/ }
            );
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }

        StringRequest stringRequest = new StringRequest(Request.Method.POST, tempUrl, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                //Log.d("response", response);
                String output = "";
                try {
                    JSONObject jsonResponse = new JSONObject(response);
                    JSONArray jsonArray = jsonResponse.getJSONArray("weather");
                    JSONObject jsonObjectWeather = jsonArray.getJSONObject(0);
                    String description = jsonObjectWeather.getString("description");
                    JSONObject jsonObjectMain = jsonResponse.getJSONObject("main");
                    double temp = jsonObjectMain.getDouble("temp") - 273.15;
                    double feelsLike = jsonObjectMain.getDouble("feels_like") - 273.15;
                    float pressure = jsonObjectMain.getInt("pressure");
                    int humidity = jsonObjectMain.getInt("humidity");
                    JSONObject jsonObjectWind = jsonResponse.getJSONObject("wind");
                    String wind = jsonObjectWind.getString("speed");
                    JSONObject jsonObjectClouds = jsonResponse.getJSONObject("clouds");
                    String clouds = jsonObjectClouds.getString("all");
                    JSONObject jsonObjectSys = jsonResponse.getJSONObject("sys");
                    String countryName = jsonObjectSys.getString("country");
                    String cityName = jsonResponse.getString("name");

                    output += "Прогнозата " +
                            "за времето в " + cityName + " (" + countryName + ")"
                            + "\n Температура: " + df.format(temp) + " Целзий"
                            + "\n Усеща се като: " + df.format(feelsLike) + " Целзий"
                            + "\n Влажност: " + humidity + "%"
                            + "\n Детайли: " + description
                            + "\n Скорост на вятъра: " + wind + "m/s (метра в секунда)"
                            + "\n Облачност: " + clouds + "%"
                            + "\n Налягане: " + pressure + " hPa";
                    tvResult.setText(output);
                } catch (JSONException e) {
                    e.printStackTrace();
                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast.makeText(getApplicationContext(), error.toString().trim(), Toast.LENGTH_SHORT).show();
            }
        });
        RequestQueue requestQueue = Volley.newRequestQueue(getApplicationContext());
        requestQueue.add(stringRequest);
    }

    public void get5LastRequests(View view) {
        ArrayList<String> results = new ArrayList<>();

        try {
            SelectSQL(
                    "SELECT * FROM WeatherUpdate ORDER BY ID DESC LIMIT 5;",
                    null,
                    new OnSelectElement() {
                        @Override
                        public void OnElementIterate(String City, String ID) {
                            results.add(City);
                        }
                    }
            );
        } catch (Exception e) {
            e.printStackTrace();
        }

        String output = TextUtils.join(", ", results);

        tvResult.setText("Последни 5 заявки: " + output);
    }
}