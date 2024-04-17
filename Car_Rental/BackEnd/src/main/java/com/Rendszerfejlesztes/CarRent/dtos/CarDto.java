package com.Rendszerfejlesztes.CarRent.dtos;

import jakarta.persistence.*;
import lombok.Data;
import org.springframework.web.multipart.MultipartFile;

import java.util.Date;

public class CarDto {
    private long id;
    private String name;
    private String color;
    private String transmission;
    private String brand;
    private String type;
    private String modelYear;
    private String description;
    private Integer price;
    private MultipartFile image;
    private byte[]  returnedImage;

}
