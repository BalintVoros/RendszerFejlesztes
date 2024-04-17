package com.Rendszerfejlesztes.CarRent.services.customer;

import com.Rendszerfejlesztes.CarRent.dtos.BookACarDto;
import com.Rendszerfejlesztes.CarRent.dtos.CarDto;
import com.Rendszerfejlesztes.CarRent.dtos.CarDtoList;
import com.Rendszerfejlesztes.CarRent.dtos.SearchCarDto;

import java.util.List;

public interface CustomerService {

    List<CarDto> getAllCars();

    CarDto getCarById(Long carId);

    boolean bookACar(Long carId, BookACarDto bookACarDto);

    List<BookACarDto> getBookingsByUserId(Long userId);

    CarDtoList searchCar(SearchCarDto searchCarDto);

}
