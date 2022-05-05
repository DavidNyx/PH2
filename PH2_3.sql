CREATE OR REPLACE PACKAGE CONTEXT_PACKAGE AS
PROCEDURE SET_CONTEXT;
END;

CREATE OR REPLACE PACKAGE BODY CONTEXT_PACKAGE IS
PROCEDURE SET_CONTEXT IS
V_USER VARCHAR2(10);
V_VAITRO VARCHAR2(20);
BEGIN
    --DBMS_SESSION.SET_CONTEXT('DNX', 'SETUP', 'TRUE');
    V_USER := SYS_CONTEXT('USERENV', 'SESSION_USER');
    BEGIN
        SELECT VAITRO INTO V_VAITRO FROM NHANVIEN WHERE MA_NV = V_USER;
        DBMS_SESSION.SET_CONTEXT('DNX', 'USER_VAITRO', V_VAITRO);
        EXCEPTION
        WHEN NO_DATA_FOUND THEN
            DBMS_SESSION.SET_CONTEXT('DNX', 'USER_VAITRO', 'NONE');
        END;
    --DBMS_SESSION.SET_CONTEXT('DNX', 'SETUP', 'FALSE');
END SET_CONTEXT;
END CONTEXT_PACKAGE;

CREATE CONTEXT DNX USING DNX.CONTEXT_PACKAGE;

GRANT EXECUTE ON DNX.CONTEXT_PACKAGE TO PUBLIC;
CREATE OR REPLACE PUBLIC SYNONYM CONTEXT_PACKAGE FOR DNX.CONTEXT_PACKAGE;

CREATE OR REPLACE TRIGGER DNX.SET_SECURITY_CONTEXT
AFTER LOGON ON DATABASE
BEGIN
    DNX.CONTEXT_PACKAGE.SET_CONTEXT;
END;

SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') USERNAME, SYS_CONTEXT('DNX', 'USER_VAITRO') VAITRO
FROM DUAL;

CREATE OR REPLACE PACKAGE SECURITY_PACKAGE AS
FUNCTION SELECT_NV(OWNER VARCHAR2, OBJNAME VARCHAR2)
RETURN VARCHAR2;
FUNCTION SELECT_BN(OWNER VARCHAR2, OBJNAME VARCHAR2)
RETURN VARCHAR2;
END SECURITY_PACKAGE;

CREATE OR REPLACE PACKAGE BODY SECURITY_PACKAGE IS
FUNCTION SELECT_NV(OWNER VARCHAR2, OBJNAME VARCHAR2)
RETURN VARCHAR2 AS
PREDICATE VARCHAR2(2000);
L_USER VARCHAR2(20);
L_VAITRO VARCHAR2(20);
BEGIN
    IF USER = 'DNX' OR SYS_CONTEXT('DNX', 'USER_VAITRO') = 'Thanh tra' THEN
        PREDICATE := NULL;
    ELSE
        PREDICATE := 'MA_NV = USER';
    END IF;
    RETURN PREDICATE;
END SELECT_NV;

FUNCTION SELECT_BN(OWNER VARCHAR2, OBJNAME VARCHAR2)
RETURN VARCHAR2 AS
PREDICATE VARCHAR2(2000);
L_USER VARCHAR2(20);
L_VAITRO VARCHAR2(20);
BEGIN
    IF USER = 'DNX' OR SYS_CONTEXT('DNX', 'USER_VAITRO') = 'Thanh tra' OR SYS_CONTEXT('DNX', 'USER_VAITRO') = 'Y sĩ/Bác sĩ' THEN
        PREDICATE := NULL;
    ELSE
        PREDICATE := 'MA_BN = USER';
    END IF;
    RETURN PREDICATE;
END SELECT_BN;

END SECURITY_PACKAGE;

GRANT EXECUTE ON DNX.SECURITY_PACKAGE TO PUBLIC;
CREATE OR REPLACE PUBLIC SYNONYM SECURITY_PACKAGE FOR DNX.SECURITY_PACKAGE;

BEGIN
DBMS_RLS.DROP_POLICY('DNX', 'NHANVIEN', 'SELECT_NV_POLICY');
END;

BEGIN
DBMS_RLS.DROP_POLICY('DNX', 'BENHNHAN', 'SELECT_BN_POLICY');
END;

BEGIN
DBMS_RLS.ADD_POLICY('DNX', 'NHANVIEN', 'SELECT_NV_POLICY', 'DNX', 'SECURITY_PACKAGE.SELECT_NV', 'SELECT');
END;

BEGIN
DBMS_RLS.ADD_POLICY('DNX', 'BENHNHAN', 'SELECT_BN_POLICY', 'DNX', 'SECURITY_PACKAGE.SELECT_BN', 'SELECT');
END;

SELECT*FROM DNX.NHANVIEN;

SELECT*FROM DNX.BENHNHAN;

INSERT INTO DNX.HSBA(MA_HSBA, MA_BN, NGAY, CHUANDOAN, MA_BS, MA_KHOA, MA_CSYT, KETLUAN) VALUES
('HS00050', 'BN00049', '02/27/2006 21:04:00', 'GK4X1', 'NV0049', 'KH04', 'CS49', 'N0PEGH0CB4NF9B');

GRANT SELECT ON DNX.CSYT TO THANHTRA;
GRANT SELECT ON DNX.KHOA TO THANHTRA;
GRANT SELECT ON DNX.DICHVU TO THANHTRA;
GRANT SELECT ON DNX.NHANVIEN TO THANHTRA;
GRANT SELECT ON DNX.BENHNHAN TO THANHTRA;
GRANT SELECT ON DNX.HSBA TO THANHTRA;
GRANT SELECT ON DNX.HSBA_DV TO THANHTRA;

GRANT INSERT ON DNX.HSBA TO CSYT;
GRANT DELETE ON DNX.HSBA TO CSYT;
GRANT INSERT ON DNX.HSBA_DV TO CSYT;
GRANT DELETE ON DNX.HSBA_DV TO CSYT;
GRANT SELECT ON DNX.HSBA TO CSYT;

GRANT SELECT ON DNX.HSBA TO YBACSI;

GRANT SELECT ON DNX.NHANVIEN TO NHANVIEN;
GRANT SELECT ON DNX.BENHNHAN TO NHANVIEN;
GRANT SELECT ON DNX.BENHNHAN TO BENHNHAN;