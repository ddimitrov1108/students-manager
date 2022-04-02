
const sqlUsers = {
    create:         `INSERT INTO users VALUES(null, ?, ?, ?, ?, now(), now())`,
    checkByEmail:   `SELECT 1 FROM users WHERE email = ?`,
    getByEmail:     `SELECT * FROM users WHERE email = ?`,
}

const sqlEdu = {
    getDegreeTypes: `SELECT eduDegreeType FROM edu_degree_types`,
    getSpecialties: `SELECT eduSpecialty FROM edu_specialties`,
    getForms:       `SELECT eduForm FROM edu_forms`
}

const sqlStudents = {
    create:                 `INSERT INTO students VALUES (null, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, now(), now())`,
    checkByFacultyNumber:   `SELECT 1 FROM students WHERE facultyNumber = ?`,
    getAll: `
        SELECT 
            students.facultyNumber, 
            students.FirstName, 
            students.lastName, 
            students.phoneNumber, 
            edu_degree_types.eduDegreeType, 
            edu_specialties.eduSpecialty, 
            edu_forms.eduForm, 
            students.eduYear, 
            students.eduGpa 
        FROM students 
            INNER JOIN edu_degree_types ON students.eduDegreeTypeId = edu_degree_types.id 
            INNER JOIN edu_specialties ON students.eduSpecialtyId = edu_specialties.id 
            INNER JOIN edu_forms ON students.eduFormId = edu_forms.id;
    `,
    getByFacultyNumber: `
        SELECT 
            students.facultyNumber, 
            students.FirstName, 
            students.lastName, 
            students.phoneNumber, 
            edu_degree_types.eduDegreeType, 
            edu_specialties.eduSpecialty, 
            edu_forms.eduForm, 
            students.eduYear, 
            students.eduGpa 
        FROM students 
            INNER JOIN edu_degree_types ON students.eduDegreeTypeId = edu_degree_types.id 
            INNER JOIN edu_specialties ON students.eduSpecialtyId = edu_specialties.id 
            INNER JOIN edu_forms ON students.eduFormId = edu_forms.id 
        WHERE students.facultyNumber = ?;
    `,
    update: `
        UPDATE students SET
            firstName = ?,
            lastName = ?,
            phoneNumber = ?,
            eduDegreeTypeId = ?,
            eduSpecialtyId = ?,
            eduFormId = ?,
            eduYear = ?,
            eduGpa = ?,
            eduPaused = ?,
            updated_at = now()
        WHERE
            facultyNumber = ?
    `,
    delete: `DELETE FROM students WHERE facultyNumber = ?`
}

export {
    sqlUsers,
    sqlEdu,
    sqlStudents
}