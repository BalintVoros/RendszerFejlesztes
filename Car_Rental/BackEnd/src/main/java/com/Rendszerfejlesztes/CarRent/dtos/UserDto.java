package com.Rendszerfejlesztes.CarRent.dtos;
import com.Rendszerfejlesztes.CarRent.enums.UserRole;
import lombok.Data;

public class UserDto {
    private long id;
    private String name;
    private String email;
    private String password;
    private UserRole userRole;
}
