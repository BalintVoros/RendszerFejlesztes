package com.Rendszerfejlesztes.CarRent.dtos;

import com.Rendszerfejlesztes.CarRent.enums.BookCarStatus;
import lombok.Data;

import java.util.Date;

@Data
public class BookACarDto {

    private Long id;

    private Date fromDate;

    private Date toDate;

    private Long days;

    private Long amount;

    private BookCarStatus bookCarStatus;

    private Long userId;

    private String email;

    private String username;

}