import { Link } from "react-router-dom";
import { Box, Heading, Button, VStack, Text} from "@chakra-ui/react";

const HomePage = () => {
    return (
      <Box p={8} textAlign="center">
        <Button colorPalette={"teal"}>Test</Button>
        <VStack spacing={4}>
          <Heading size="2xl">Phishing Awareness Training Platform</Heading>
          <Text fontSize="lg" color="gray.600">
            Learn how to recognize and avoid phishing attacks through interactive training.
          </Text>
          <VStack spacing={4} mt={8}>
            <Link to="/quiz">
                 Start Training
            </Link>

          </VStack>
        </VStack>
      </Box>
    );
  };

  export default HomePage;
  