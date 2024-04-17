package com.Rendszerfejlesztes.CarRent.services.admin;

import com.Rendszerfejlesztes.CarRent.dtos.BookACarDto;
import com.Rendszerfejlesztes.CarRent.dtos.CarDto;
import com.Rendszerfejlesztes.CarRent.dtos.CarDtoList;
import com.Rendszerfejlesztes.CarRent.dtos.SearchCarDto;

import java.io.IOException;
import java.util.List;

public interface AdminService {

    boolean postCar(CarDto carDto);

    List<CarDto> getAllCars();

    void deleteCar(Long carId);

    CarDto getCarById(Long cardId);

    boolean updateCar(Long carId,CarDto carDto) throws IOException;

    List<BookACarDto> getBookings();

    boolean changeBookingStatus(Long bookingId, String status);

    CarDtoList searchCar(SearchCarDto searchCarDto);

}
