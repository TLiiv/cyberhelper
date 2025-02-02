import { Box, Heading, Text } from "@chakra-ui/react";

const TutorialPage = () => (
    <Box p={8} textAlign="center">
      <Heading>About This Platform</Heading>
      <Text mt={4} color="gray.600">
        This platform is designed to help users learn to identify phishing attacks through dynamic tests and feedback.
      </Text>
    </Box>
  );

  export default TutorialPage;