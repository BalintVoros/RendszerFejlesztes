package com.Rendszerfejlesztes.CarRent.dtos;

import com.Rendszerfejlesztes.CarRent.enums.UserRole;
import lombok.Data;

@Data
public class UserDto {

    private Long id;

    private String name;

    private String email;

    private String password;

    private UserRole userRole;

}
