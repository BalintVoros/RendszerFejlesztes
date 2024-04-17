package com.Rendszerfejlesztes.CarRent.dtos;

import com.Rendszerfejlesztes.CarRent.enums.UserRole;
import lombok.Data;

@Data
public class AuthenticationResponse {

    private String jwt;

    private UserRole userRole;

    private Long userId;

}
