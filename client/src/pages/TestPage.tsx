import EmailDashboard from "@/components/EmailDashboard";
import { Box, Heading, Button, VStack, Text, Container } from "@chakra-ui/react";

const TestPage: React.FC = () => {

  return (
      <Box maxW="1680px" mx="auto" px={4} position="relative">
        <EmailDashboard />
      </Box>
  );
}




  export default TestPage;