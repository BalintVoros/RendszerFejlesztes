package com.Rendszerfejlesztes.CarRent.repositories;

import com.Rendszerfejlesztes.CarRent.entities.Users;
import com.Rendszerfejlesztes.CarRent.enums.UserRole;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.Optional;

@Repository
public interface UserRepository extends JpaRepository<Users, Long> {
    Optional<Users> findFirstByEmail(String email);

    Users findByUserRole(UserRole userRole);

}
