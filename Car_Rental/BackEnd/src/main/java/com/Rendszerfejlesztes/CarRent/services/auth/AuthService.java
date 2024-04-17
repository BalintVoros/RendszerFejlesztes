package com.Rendszerfejlesztes.CarRent.services.auth;

import com.Rendszerfejlesztes.CarRent.dtos.SignupRequest;
import com.Rendszerfejlesztes.CarRent.dtos.UserDto;

public interface AuthService {

    UserDto createCustomer(SignupRequest signupRequest);

    boolean hasCustomerWithEmail(String email);

}
