namespace BoostedTrivia
{
    class SystemSettingsDAO
    {
        private int numberOfQuestions;

        public SystemSettingsDAO() {
            /*
                Connection conn = null;
                Properties connectionProps = new Properties();
                connectionProps.put("user", "myuser");
                connectionProps.put("password", "mypassword");

                conn = DriverManager.getConnection(
                    "jdbc:mysql://localhost:3306/",
                    connectionProps);
                    */
        }

        public int getNumberOfQuestions() {
            return numberOfQuestions;
        }
    }
}
