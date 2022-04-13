alter session set "_oracle_script"=true;

CREATE USER admin_temp IDENTIFIED BY admintemp;
GRANT CREATE SESSION TO admin_temp with admin option;

