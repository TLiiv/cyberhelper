import EmailDashboard from "@/components/EmailDashboard";
import { Box, Heading, Button, VStack, Text, Container, Theme } from "@chakra-ui/react";

const TestPage: React.FC = () => {

  return (
    
      <Box maxW="1680px" mx="auto" px={4} position="relative">
        <Theme appearance="light" borderRadius="4xl">
          <EmailDashboard />
          </Theme>
      </Box>
  );
}




  export default TestPage;